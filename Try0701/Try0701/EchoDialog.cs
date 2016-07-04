﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.FormFlow;



namespace Try0701
{

    public enum SandwichOptions
    {
        BLT, BlackForestHam, BuffaloChicken, ChickenAndBaconRanchMelt, ColdCutCombo, MeatballMarinara,
        OvenRoastedChicken, RoastBeef, RotisserieStyleChicken, SpicyItalian, SteakAndCheese, SweetOnionTeriyaki, Tuna,
        TurkeyBreast, Veggie
    };
    public enum LengthOptions { SixInch, FootLong };

    [Serializable]
    public class EchoDialog //: IDialog<object>
    {
        public SandwichOptions? Sandwich;
        public LengthOptions? Length;
        public static IForm<EchoDialog> BuildForm()
        {
            return new FormBuilder<EchoDialog>()
                    .Message("Welcome to the simple sandwich order bot!")
                    .Build();
        }
    };

    //    protected int count = 1;

    //    public async Task StartAsync(IDialogContext context)
    //    {
    //        context.Wait(MessageReceivedAsync);
    //    }

    //    public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<Message> argument)
    //    {
    //        var message = await argument;
    //        if (message.Text == "reset")
    //        {
    //            PromptDialog.Confirm(
    //                context,
    //                AfterResetAsync,
    //                "Are you sure you want to reset the count?",
    //                "Didn't get that!",
    //                promptStyle: PromptStyle.Inline);
    //        }
    //        else
    //        {
    //            await context.PostAsync(string.Format("{0}: You said {1}", this.count++, message.Text));
    //            context.Wait(MessageReceivedAsync);
    //        }
    //    }

    //    public async Task AfterResetAsync(IDialogContext context, IAwaitable<bool> argument)
    //    {
    //        var confirm = await argument;
    //        if (confirm)
    //        {
    //            this.count = 1;
    //            await context.PostAsync("Reset count.");
    //        }
    //        else
    //        {
    //            await context.PostAsync("Did not reset count.");
    //        }
    //        context.Wait(MessageReceivedAsync);
    //    }
    //}
}
