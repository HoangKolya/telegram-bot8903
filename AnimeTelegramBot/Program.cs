using System;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Args;
using System.Threading;

namespace AnimeTelegramBot
{
    class Program
    {
        static Random rand = new Random();
        
        private static TelegramBotClient botClient;
        private static CancellationTokenSource cts = new CancellationTokenSource();
        static void Main(string[] args)
        {
           
            botClient = new TelegramBotClient("5249468983:AAEioS4-bt3uKyOLPz0_XkxM16uqNn9VKgo");

            botClient.StartReceiving();
            botClient.OnMessage += OnMassageHandler;
            Console.ReadLine();
            botClient.StartReceiving();
        }

        private static async void OnMassageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;

            if (msg.Text != null)
            {
                bool Error = false;

                string name = msg.From.FirstName;

                string messageOfUser = msg.Text;

                char[] arrayOfMassege = messageOfUser.ToCharArray();

                string anotherUser = "";

                string pizda = anotherUser;
                
                for (int i = 0; i < arrayOfMassege.Length; i++)
                {
                    if (8 + i < arrayOfMassege.Length)
                    {
                        anotherUser += arrayOfMassege[8 + i];
                    }

                }

                    try
                {
                    if (msg.Text == $"OwO hug {anotherUser}" && Error == false)
                    {
                        string[] ArrayOfGifsHugs = new string[10]
                        { "https://acegif.com/wp-content/gif/anime-hug-59.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-86.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-83.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-14.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-63.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-27.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-19.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-2.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-4.gif",
                      "https://acegif.com/wp-content/gif/anime-hug-6.gif",};

                        int RandomNumber1 = rand.Next(0, ArrayOfGifsHugs.Length - 1);

                        string gif1 = ArrayOfGifsHugs[RandomNumber1];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif1,
                            caption: $"{name} обнимает {anotherUser}",
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO cry" && Error == false)
                    {
                        string[] ArrayOfGifsCry = new string[10]
                        { "https://c.tenor.com/85qsz-9jRVQAAAAM/cropped-sad.gif",
                      "https://c.tenor.com/6TbdzlP-d4IAAAAM/anime-anime-hug.gif",
                      "https://c.tenor.com/3lDNGJnzSt0AAAAM/anime-hug.gif",
                      "https://c.tenor.com/iZMRkQVZ2QEAAAAM/anime-cry.gif",
                      "https://c.tenor.com/z-C4PsjA6aQAAAAM/anime-sad.gif",
                      "https://c.tenor.com/SCurbvPofAgAAAAM/abeernono-crying.gif",
                      "https://c.tenor.com/YttS0f50m2IAAAAM/crying-face-cry.gif",
                      "https://c.tenor.com/1jcx-LWSe9wAAAAM/cry-misaka.gif",
                      "https://c.tenor.com/8pZsYx_6O9kAAAAM/chitoge-nisekoi.gif",
                      "https://c.tenor.com/hW8FHYajTLsAAAAM/noriko-gunbuster.gif",};

                        int RandomNumber2 = rand.Next(0, ArrayOfGifsCry.Length - 1);

                        string gif2 = ArrayOfGifsCry[RandomNumber2];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif2,
                            caption: name + " плачет((",
                            replyToMessageId: msg.MessageId);
                    }

                    if (msg.Text == $"OwO bze {anotherUser}")
                    {


                        string[] ArrayOfGifsBoozes = new string[]
                        {
                      "https://64.media.tumblr.com/99bfd2f30a86e96c1d5f32bed16de163/tumblr_njtd0rP5Xb1u6nj7vo1_500.gif",
                      "https://thumbs.gfycat.com/PitifulHonorableDassierat-size_restricted.gif",
                      "https://c.tenor.com/BQMUtflqcTsAAAAC/grand-blue-cheers.gif",
                      "http://img2.reactor.cc/pics/post/full/Witch-Craft-Works-Anime-Anime-Гифки-Неко-1051352.gif",
                      "https://c.tenor.com/hVJtM97eQm4AAAAC/cheers-clink.gif"
                        };

                        int RandomNumber2 = rand.Next(0, ArrayOfGifsBoozes.Length - 1);

                        string gif2 = ArrayOfGifsBoozes[RandomNumber2];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif2,
                            caption: name + " бухает c " + anotherUser,
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == "OwO kiss" + anotherUser)
                    {
                        string[] ArrayOfGifsKiss = new string[10]
                        { "https://c.tenor.com/hK8IUmweJWAAAAAM/kiss-me-люблю.gif",
                      "https://c.tenor.com/DDmZqcOZJisAAAAM/anime.gif",
                      "https://c.tenor.com/F02Ep3b2jJgAAAAM/cute-kawai.gif",
                      "https://c.tenor.com/etSTc3aWspcAAAAM/yuri-kiss.gif",
                      "https://c.tenor.com/_6hgYIXDWpUAAAAM/kiss-anime.gif",
                      "https://c.tenor.com/lupxFXBF-BYAAAAM/anime-sweet.gif",
                      "https://c.tenor.com/-ScgZrF7Y0wAAAAM/yuri-kiss.gif",
                      "https://c.tenor.com/W6nvj1_GMd4AAAAM/cute-couple.gif",
                      "https://c.tenor.com/Fyq9izHlreQAAAAM/my-little-monster-haru-yoshida.gif",
                      "https://c.tenor.com/06lz817csVgAAAAM/anime-anime-kiss.gif",};

                        int RandomNumber = rand.Next(0, ArrayOfGifsKiss.Length - 1);

                        string gif = ArrayOfGifsKiss[RandomNumber];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif,
                            caption: name + " поцеловал" + anotherUser,
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO beat" + anotherUser && Error == false)
                    {
                        string[] ArrayOfGifsBeat = new string[]
                        { "https://c.tenor.com/4p2gwNLsxBEAAAAM/whizzy-imposterfox.gif",
                      "https://c.tenor.com/i2Q6ReOAR4UAAAAM/rage-anime.gif",
                      "https://c.tenor.com/PMCDFLsJodEAAAAM/fight-fighting.gif",
                      "https://c.tenor.com/EfhPfbG0hnMAAAAM/slap-handa-seishuu.gif",
                      "https://c.tenor.com/w4T323o46uYAAAAM/anime-bite.gif",
                      "https://c.tenor.com/OuYAPinRFYgAAAAM/anime-slap.gif",
                      "https://c.tenor.com/LEgnGzli8VMAAAAM/anime-fight.gif",
                      "https://i.gifer.com/VCCJ.gif",
                      "https://i.gifer.com/embedded/download/Nkyv.gif",
                       "https://i.gifer.com/Ke8y.gif"};


                        int RandomNumber4 = rand.Next(0, ArrayOfGifsBeat.Length - 1);

                        string gif4 = ArrayOfGifsBeat[RandomNumber4];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif4,
                            caption: name + " ударил" + anotherUser,
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO smile" && Error == false)
                    {
                        string[] ArrayOfGifsSmile = new string[]
                        { "https://c.tenor.com/kiw3AxGnfSgAAAAM/anime-smile-anime-cute-boy.gif",
                      "https://c.tenor.com/nBWlYPbKxzwAAAAM/anime-happy.gif",
                      "https://c.tenor.com/U1p83COiAPYAAAAM/anime-happy-anime-smile.gif",
                      "https://c.tenor.com/Ur_pBB1YBlwAAAAM/himouto-umaru-chan-smile.gif",
                      "https://c.tenor.com/W12sevEG_I0AAAAM/anime-smiling.gif",
                      "https://c.tenor.com/sKgLJlIbtFgAAAAM/heart-love.gif",
                      "https://c.tenor.com/9R7fzXGeRe8AAAAM/fantasista-doll-anime.gif",
                      "https://c.tenor.com/WfyJfkMQQNsAAAAM/genshin-impact-genshin.gif",};

                        int RandomNumber5 = rand.Next(0, ArrayOfGifsSmile.Length - 1);

                        string gif5 = ArrayOfGifsSmile[RandomNumber5];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif5,
                            caption: name + " улыбается",
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO kill" + anotherUser && Error == false)
                    {
                        string[] ArrayOfGifsKill = new string[]
                        { "https://c.tenor.com/_3i8LBmRpWQAAAAM/akame-ga-kill-anime.gif",
                      "https://c.tenor.com/YtRZgG_rRkwAAAAM/lubbock-akame-ga-kill.gif",
                      "https://c.tenor.com/HltbzNICQeAAAAAM/satsuki-kiryuin-kill-la-kill.gif",
                      "https://c.tenor.com/VX45OoPs008AAAAM/gun-to-head-gun.gif",
                      "https://c.tenor.com/LYbcHJqDa-IAAAAM/minecraft-cursed.gif",
                      "https://c.tenor.com/6VM7lzsBSuUAAAAM/id-invaded-gun.gif",
                      "https://c.tenor.com/4RX1buTX6w4AAAAM/kill-anime.gif" };


                        int RandomNumber6 = rand.Next(0, ArrayOfGifsKill.Length - 1);

                        string gif6 = ArrayOfGifsKill[RandomNumber6];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif6,
                            caption: name + " убил" + anotherUser,
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO pat {anotherUser}" && Error == false)
                    {
                        string[] ArrayOfGifsPat = new string[]
                        { "https://c.tenor.com/N41zKEDABuUAAAAM/anime-head-pat-anime-pat.gif",
                      "https://c.tenor.com/wLqFGYigJuIAAAAM/mai-sakurajima.gif",
                      "https://c.tenor.com/DCMl9bvSDSwAAAAM/pat-head-gakuen-babysitters.gif",
                      "https://c.tenor.com/AYEu-gdwHD8AAAAM/love-love-ryant.gif",
                      "https://c.tenor.com/OGnRVWCps7IAAAAM/anime-head-pat.gif",
                      "https://c.tenor.com/QAIyvivjoB4AAAAM/anime-anime-head-rub.gif",
                      "https://c.tenor.com/dLdNYQrLsp4AAAAM/umaru-frown.gif",
                      "https://c.tenor.com/G14pV-tr0NAAAAAM/anime-head.gif",
                      "https://c.tenor.com/i7nXGbPLqTsAAAAM/anime-hug.gif",
                      "https://c.tenor.com/pvYCizt4_W8AAAAM/rachnera-monster-musume.gif",
                      "https://c.tenor.com/JWx5wmF6bqAAAAAM/charlotte-pat.gif",
                      "https://c.tenor.com/S3pfBHXIDYQAAAAM/ijiranaide-nagatoro-anime-pat.gif"};

                        int RandomNumber7 = rand.Next(0, ArrayOfGifsPat.Length - 1);

                        string gif7 = ArrayOfGifsPat[RandomNumber7];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif7,
                            caption: name + " погладил " + anotherUser,
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO bite" + anotherUser)
                    {
                        string[] ArrayOfGifsBite = new string[]
                        { "https://i.pinimg.com/originals/ca/eb/32/caeb32ef58807c7563460d96a3f7ecc9.gif",
                      "https://i.gifer.com/MYX2.gif",
                      "https://i.gifer.com/9fjL.gif",
                      "https://img1.ak.crunchyroll.com/i/spire1/170558ac72fc354a20f6589cb7bc06491531918753_full.gif",
                      "https://img1.ak.crunchyroll.com/i/spire1/38f541ca5c7880b947ea0345e4603a0f1405388674_full.gif"};

                        int RandomNumber786 = rand.Next(0, ArrayOfGifsBite.Length - 1);

                        string gif09 = ArrayOfGifsBite[RandomNumber786];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif09,
                            caption: name + " укусил" + anotherUser,
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO booze" && Error == false)
                    {
                        string[] ArrayOfGifsBooze = new string[]
                        { "https://animegif.ru/up/photos/album/oct17/171022_1099.gif",
                      "https://c.tenor.com/e87FtvOXjmUAAAAd/drinking-alcohol.gif",
                      "https://1.bp.blogspot.com/-e0XvwF0Wehs/WHnGNKKbT3I/AAAAAAAAtSw/8dUjyxDG6dEkw3hpOyeMisxGY5PrcXlwwCPcB/s1600/Omake%2BGif%2BAnime%2B-%2BAo%2Bno%2BExorcist%2B-%2BKyoto%2BFujouou-hen%2B-%2BEpisode%2B2%2B-%2BShura%2BDrinks%2BJuice.gif",
                      "https://giffiles.alphacoders.com/155/155028.gif",
                      "https://pa1.narvii.com/6517/c908b6dc9a512f0b8cdb48714945a58f48a04e5c_hq.gif",
                      "https://64.media.tumblr.com/bca8460972253f4c346a0fc4bcb2c5ee/tumblr_oomrjcKfzb1wn7u8so1_1280.gif",
                      "https://i.gifer.com/IcT8.gif",
                      "https://64.media.tumblr.com/99bfd2f30a86e96c1d5f32bed16de163/tumblr_njtd0rP5Xb1u6nj7vo1_500.gif",
                      "https://data.whicdn.com/images/57244634/original.gif",
                      "https://i.gifer.com/JiS.gif"
                        };

                        int RandomNumber9 = rand.Next(0, ArrayOfGifsBooze.Length - 1);

                        string gif9 = ArrayOfGifsBooze[RandomNumber9];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif9,
                            caption: name + " бухает",
                            replyToMessageId: msg.MessageId);

                        
                    }
                    else if (msg.Text == $"OwO drink" && Error == false)
                    {
                        string[] ArrayOfGifsDrink = new string[10]
                        { "https://c.tenor.com/RJ9qC27CvCEAAAAM/giorno-tea.gif",
                      "https://c.tenor.com/lFgNDWZT7fkAAAAM/fox-anime.gif",
                      "https://c.tenor.com/ecR-CbFWx6UAAAAM/anime-sip.gif",
                      "https://c.tenor.com/11lavQXjjQ0AAAAM/sips-tea-anime.gif",
                      "https://c.tenor.com/Nn4ydcdsdbEAAAAM/manga-rascal-does-not-dream-of-bunny-girl-senpai.gif",
                      "https://c.tenor.com/BbYKmVG-KTkAAAAM/azur-lane-nagato.gif",
                      "https://c.tenor.com/A0RXwLmaaj4AAAAM/ohnaruto-muni-d4dj-first-mix.gif",
                      "https://c.tenor.com/U06tekgz-OQAAAAM/city-hunter-ryo-saeba.gif",
                      "https://c.tenor.com/EkXJiUaOd3MAAAAM/remilia-scarlet-touhou.gif",
                      "https://c.tenor.com/81QhT9gmQMkAAAAM/kaguya-shinomiya-tea.gif",};

                        int RandomNumber10 = rand.Next(0, ArrayOfGifsDrink.Length - 1);

                        string gif10 = ArrayOfGifsDrink[RandomNumber10];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif10,
                            caption: name + " пьет",
                            replyToMessageId: msg.MessageId);
                    }
                    
                    else if (msg.Text == $"OwO angry" && Error == false)
                    {
                        string[] ArrayOfGifsAngry = new string[10]
                        { "https://c.tenor.com/rzDkOlEDun0AAAAM/hayase-nagatoro-nagatoro-angry.gif",
                      "https://c.tenor.com/u7pzpX6_Q5cAAAAM/anime-girl.gif",
                      "https://c.tenor.com/X3x3Y2mp2W8AAAAM/anime-angry.gif",
                      "https://c.tenor.com/u7pzpX6_Q5cAAAAC/anime-girl.gif",
                      "https://c.tenor.com/kTOmea7XdH4AAAAM/anime-angry.gif",
                      "https://c.tenor.com/jgFVzr3YeJwAAAAM/date-a-live-rage.gif",
                      "https://c.tenor.com/PqJsoGX4qOwAAAAM/angry-cat-noises-shout.gif",
                      "https://c.tenor.com/Ds187JeCgckAAAAM/animehit-fugirl.gif",
                      "https://c.tenor.com/ikKAd57zDEwAAAAM/anime-mad.gif",
                      "https://c.tenor.com/pI5JTP4Z9w0AAAAM/bungou-stray-dogs-wan-chuuya-nakahara.gif",};

                        int RandomNumber = rand.Next(0, ArrayOfGifsAngry.Length - 1);

                        string gif = ArrayOfGifsAngry[RandomNumber];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif,
                            caption: name + " очень злиться",
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO fuck" + anotherUser && Error == false)
                    {
                        string[] ArrayOfGifsFuck = new string[]
                        {"https://c.tenor.com/i7S2Taae5H8AAAAM/sex-anime.gif",
                         "https://c.tenor.com/Tj9ECfelQRUAAAAM/anime-redo-of-healer.gif",
                         "https://c.tenor.com/-UolTt_O2JoAAAAM/hot-sex.gif",
                         "https://c.tenor.com/5Me54nLWWE8AAAAM/anime-sex-sign.gif",
                         "https://c.tenor.com/R8W1vh6X6uMAAAAM/anime-love.gif",
                         "https://c.tenor.com/gLO_ID1u4pwAAAAM/nagatoro-anime-love.gif"};

                        int RandomNumber = rand.Next(0, ArrayOfGifsFuck.Length - 1);

                        string gif = ArrayOfGifsFuck[RandomNumber];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif,
                            caption: name + " ебет" + anotherUser,
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO dance" && Error == false)
                    {
                        string[] ArrayOfGifsDance = new string[]
                        {"https://c.tenor.com/9eu9F42NQuYAAAAM/dance-anime-cool.gif",
                         "https://c.tenor.com/15NLF1281h8AAAAM/anime-dance.gif",
                         "https://c.tenor.com/mKTS5nbF1zcAAAAM/cute-anime-dancing.gif",
                         "https://c.tenor.com/LP6rGpITvlsAAAAM/chill.gif",
                         "https://c.tenor.com/xHdQRsnCSVYAAAAM/kakashi-dancing.gif",
                         "https://c.tenor.com/oOrsGFrf-6wAAAAM/dance-dance-moves.gif",
                         "https://c.tenor.com/2vRn7mgoMRMAAAAM/cute-anime-dance.gif",
                         "https://c.tenor.com/cglS81TpHAIAAAAM/rainbow-anime.gif",
                         "https://c.tenor.com/R0PPU-xQlHAAAAAM/anime.gif",
                         "https://c.tenor.com/wfFFtKqPhI8AAAAM/anime-dance.gif",
                         "https://c.tenor.com/11XjE6Qh0YYAAAAM/copy-cat-vibe.gif",
                         "https://c.tenor.com/iCu7HWCukbMAAAAM/senchous-kladys.gif"};

                        int RandomNumber = rand.Next(0, ArrayOfGifsDance.Length - 1);

                        string gif = ArrayOfGifsDance[RandomNumber];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif,
                            caption: name + " танцует, присоеденяйтесь!)",
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO help" && Error == false)
                    {

                        Message message = await botClient.SendTextMessageAsync(
                            chatId: msg.Chat.Id,
                            text: "OwO hug {somebody} - обнять кого-то \n " +
                                  "OwO cry - плакать \n" +
                                  "OwO kiss {somebody} - поцеловать кого-то \n" +
                                  "OwO beat {somebody}  - бить кого-то \n" +
                                  "OwO smile - улыбаться \n" +
                                  "OwO kill {somebody} - убить кого-то \n" +
                                  "OwO pat {somebody} - погладить кого-то \n" +
                                  "OwO bite {somebody} - кусать кого-то \n" +
                                  "OwO booze - бухать \n" +
                                  "OwO bze {somebody} - бухать с кем-то \n" +
                                  "OwO drink - пить чай или кофе \n" +
                                  "OwO angry - злиться \n" +
                                  "OwO dance - танцевать \n" +
                                  "OwO fuck {somebody} - выебать кого-то \n" +
                                  "OwO dead inside - ты даун \n" +
                                  "OwO eat - кушать",
                            replyToMessageId: msg.MessageId); 
                    }
                    else if (msg.Text == $"OwO eat" && Error == false)
                    {
                        string[] ArrayOfGifsEat = new string[]
                        {"https://i.gifer.com/1eZk.gif",
                         "https://i.gifer.com/5HsF.gif",
                         "https://img.gifmagazine.net/gifmagazine/images/543083/original.gif",
                         "https://i.pinimg.com/originals/31/d0/76/31d076b2a23bc3f34344728495166acc.gif",
                         "https://i.gifer.com/TJrF.gif",
                         "https://i.gifer.com/WUzZ.gif",
                         "https://pa1.narvii.com/6746/cdfcd8f05dd9716b678e1ee46b16931a5af328ad_hq.gif",
                         "https://media.moddb.com/images/groups/1/25/24269/ezgif-3-ac5f39c0ad.gif",
                         "https://i.gifer.com/WopO.gif",
                         "https://data.whicdn.com/images/245758736/original.gif"
                         };

                        

                        int RandomNumber = rand.Next(0, ArrayOfGifsEat.Length - 1);

                        string gif = ArrayOfGifsEat[RandomNumber];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif,
                            caption: name + " кушает, хрум хрум",
                            replyToMessageId: msg.MessageId);
                    }
                    else if (msg.Text == $"OwO dead inside" && Error == false)
                    {
                        string[] ArrayOfGifsDeadInside = new string[]
                        {"https://data.whicdn.com/images/189703871/original.gif",
                         "https://i.gifer.com/5CPc.gif",
                         "https://i.pinimg.com/originals/39/6b/6a/396b6a7640f1ed13a07969e55b57d55e.gif",
                         "https://data.whicdn.com/images/331756941/original.gif",
                         "https://i.pinimg.com/originals/15/f9/b3/15f9b3261ed0fd7c6ca1a2a03e9713a3.gif",
                         "https://i.gifer.com/RyqN.gif",
                         "https://pixelbox.ru/wp-content/uploads/2021/09/anime-gif-discord-23.gif",
                         "https://data.whicdn.com/images/262631559/original.gif"
                         };

                        int RandomNumber = rand.Next(0, ArrayOfGifsDeadInside.Length - 1);

                        string gif = ArrayOfGifsDeadInside[RandomNumber];

                        Message message = await botClient.SendAnimationAsync(
                            chatId: msg.Chat.Id,
                            animation: gif,
                            caption: name + "...Теперь..Гуль",
                            replyToMessageId: msg.MessageId);
                    }
                }
                catch(Telegram.Bot.Exceptions.ApiRequestException)
                {

                }

            }
        }    
    }
}
