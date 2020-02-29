using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System.IO.IsolatedStorage;


namespace Discord_Bot_Tutorial.CommandList
{
    public class Commands
    {
       

        [Command("ping")]
        [Description("Test Command")]

        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("pong").ConfigureAwait(false);
        }
        
        [Command("smite")]
        [RequireRolesAttribute("Owner")]
        [Description("Ban")]

        public async Task Smite(CommandContext ctx, DiscordMember member)
        {
            await ctx.Guild.BanMemberAsync(member).ConfigureAwait(false);
            Console.WriteLine("Banned " + member);
            await ctx.Channel.SendMessageAsync(":zap:").ConfigureAwait(false);
        }
        
        [Command("unban")]
        [RequireRolesAttribute("Owner")]
        [Description("NOTE: You need the ID of the user you banned to successfully unban them")]

        public async Task unBan(CommandContext ctx, DiscordUser user)
        {
            await ctx.Guild.UnbanMemberAsync(user).ConfigureAwait(false);
            Console.WriteLine("Unbanned " + user);
            await ctx.Channel.SendMessageAsync(user + " has been unbanned").ConfigureAwait(false);
        }

        [Command("memez")]
        
        public async Task Memez (CommandContext ctx)
        {
            string file1 = @"C:\Users\004169\Desktop\Source Code\Images\yesMemeTest.jpg";
            string file2 = @"C:\Users\004169\Desktop\Source Code\Images\yesMemeTest1.jpg";
            string file3 = @"C:\Users\004169\Desktop\Source Code\Images\yesMemeTest2.jpg";
            string file4 = @"C:\Users\004169\Desktop\Source Code\Images\yesMemeTest3.jpg";
            string file5 = @"C:\Users\004169\Desktop\Source Code\Images\yesMeme5.jpg";
            string file6 = @"C:\Users\004169\Desktop\Source Code\Images\yesMeme6.jpg";
            string file7 = @"C:\Users\004169\Desktop\Source Code\Images\yesMeme7.jpg";
            string file8 = @"C:\Users\004169\Desktop\Source Code\Images\yesMeme8.jpg";
            string file9 = @"C:\Users\004169\Desktop\Source Code\Images\yesMeme9.jpg";
            string file10 = @"C:\Users\004169\Desktop\Source Code\Images\yesMeme10.jpg";

            Random rnd = new Random();

            string[] files = { file1, file2, file3, file4, file5, file6, file7, file8, file9, file10 };
            int rndNum = rnd.Next(1, 10);
            string fileLocation = files[rndNum];

            await ctx.Channel.SendFileAsync(fileLocation);
        }


    }
}
