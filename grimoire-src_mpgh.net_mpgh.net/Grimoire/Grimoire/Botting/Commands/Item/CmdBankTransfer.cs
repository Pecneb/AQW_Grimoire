﻿using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Item
{
    public class CmdBankTransfer : IBotCommand
    {
        public bool TransferFromBank { get; set; }
        public string ItemName { get; set; }

        public async Task Execute(IBotEngine instance)
        {
            if (TransferFromBank)
            {
                if (Player.Bank.ContainsItem(ItemName))
                {
                    Player.Bank.TransferFromBank(ItemName);
                    await instance.WaitUntil(() => !Player.Bank.ContainsItem(ItemName));
                }
            }
            else
            {
                if (Player.Inventory.ContainsItem(ItemName, "*"))
                {
                    Player.Bank.TransferToBank(ItemName);
                    await instance.WaitUntil(() => !Player.Inventory.ContainsItem(ItemName, "*"));
                }
            }
        }

        public override string ToString()
        {
            return $"{(TransferFromBank ? "Bank -> Inventory:" : "Inventory -> Bank:")} {ItemName}";
        }
    }
}
