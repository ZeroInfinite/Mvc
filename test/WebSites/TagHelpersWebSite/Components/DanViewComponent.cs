﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Mvc;

namespace TagHelpersWebSite
{
    public class DanViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(JacketColor jacketColor)
        {
            var colorReplacement = string.Format("<span style='color:{0}'>#</span>", jacketColor);

            var resultString = DanString
                .Replace("#", colorReplacement)
                .Replace(Environment.NewLine, "<br>")
                .Replace("\n", "<br>");

            return View<string>(resultString);
        }

        private const string DanString = @"
???????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????+
???????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????+
??????????????????????????????????????????????????????????????????????????????????????????????????I77III$77I7III???????????????????????????????????????????????????????????????????????????????????????+
?????????????????????????????????????????????????????????????????????????????????????????I??7$OO8ODNNDDDNNNNDDNN8Z8Z$77????????????????????????????????????????????????????????????????????????????????+
?????????????????????????????????????????????????????????????????????????????????????I7IZO88NDNNDDNNMNNNMMNMNNMNNMMNDDDDOOII???????????????????????????????????????????????????????????????????????????+
???????????????????????????????????????????????????????????????????????????????I?7I$ZDN8DNNNNNNDNNNNNMNMMMMMMMNNNMNNMNNNDDDD88$$???????????????????????????????????????????????????????????????????????+
???????????????????????????????????????????????????????????????????????????I??7O88DDDNNNDNNNNNNNDDDNNNNNNMNNNNNMNNMMNMNNNNNDNN8D8Z$$???????????????????????????????????????????????????????????????????+
???????????????????????????????????????????????????????????????????????????I$O8DDDNDNNDNNDDDNNNDNNNNNDNNNNNNNNNNNNNNDMMMNMMNNNND8D88$7??+??????????????????????????????????????????????????????????????+
?????????????????????????????????????????????????????????????????????????7Z8NDDDNNNNDNDNNNNDNNNNNNNNDNNDNNNNDNNNNNNNNNNNNNMNNMNNNDDDOD$O$??????????????????????????????????????????????????????????????+
??????????????????????????????????????????????????????????????????????I$8DNNNNDNNNDNNDDDD8DNDNNNDDDDDDDDDDDNDNNNNNNDDNNNNNMMNNNNNNND8NZDD8O$I??????????????????????????????????????????????????????????+
???????????????????????????????????????????????????????????????????I7O8DDNDNNNNNNNNNN8D8DNDNDD8DDDD88DDD8D8DDDDNNNNNNNDNDDDNNNDDMMNDNDDND88DOZ?????????????????????????????????????????????????????????+
?????????????????????????????????????????????????????????????????IIO88NDDDNNDNDNDDD88O88DDDDDN8DD8888O88888DDDDNDDN8D8DDDDDDDDDDDNNNDDNNDNDOOO$I???????????????????????????????????????????????????????+
????????????????????????????????????????????????????????????????IONDDNDDNMNNND888OZZOOODDO888ODO8OOZOOOOOO88888DDDDDD8DDDD88888DDNNNN8NDNDDO8D8OZ??????????????????????????????????????????????????????+
??????????????????????????????????????????????????????????????I7OD8NDDD8DNDNN88OZ$$$$ZOOO8888OOOOZOOZZZZOZZ8888888OOOZ8OOOOOO8O88888NNNDN8DDNO888O$I???????????????????????????????????????????????????+
??????????????????????????????????????????????????????????????7ZDDDDNNDNDND8OZZZ$$$ZZZOZOOO8OZOZZZZ$Z$ZZZOO$ZZOOOOOZOZZZZZZOOOOOOOO88DDNN8NDN8DNN8DZI??????????????????????????????????????????????????+
????????????????????????????????????????????????????????????IOD8DNDDDDNDD8OOZ$$$$$$$$$Z$8$ZOZ$ZZ$77777$7$$$$$$ZOOZ$$Z$$ZZZZZZZZOOZOOO8DDNNNN8DDD8DNDZ7I????????????????????????????????????????????????+
???????????????????????????????????????????????????????????7ONNDDDDDDDDDOOZ$$$77777777$$Z$77$$77III77I777Z$7$$$$$77777$$$$$$$ZZZOOOOOO8DDDNNNDNDNONND8Z7I??????????????????????????????????????????????+
??????????????????????????????????????????????????????????7$8DD8NDDN8D8Z$$777777II77777777$7$$$7IIIIIII7II77I77777777777777$$$$$ZZZZOOO88ODNNNDDDDODNNN8I??????????????????????????????????????????????+
?????????????????????????????????????????????????????????IZ8888DDDDD88Z$777777IIIIIIIII77$777II?IIIIIIIIIII7III777III777II77$$$Z$$Z$ZZZOOO88DD8NN88DDDDNDZ?????????????????????????????????????????????+
???????????????????????????????????????????????????????IZDDD88DDD888Z7777IIIIIIII?IIII?III7I???I???II??I?777III?IIIIIIIIIII777$$$$$$$$$ZZOO88DDNDDDDDNNDD8ZI???????????????????????????????????????????+
??????????????????????????????????????????????????????I$8NN8OD8N8D8Z$7I7IIIIIIII?I??I??I???????III???????I?I?I??III?IIIIII77777$$$$$$$$$ZZO88DDNDDDDNDDOD88O7??????????????????????????????????????????+
?????????????????????????????????????????????????????IO8DNN8D8DDD8Z$7I7IIIIIIIII????????+????I???++++++++??+???????IIIIIIII77777$7$$7$$$$$ZO88D8DDDND8NNDNNNZI?????????????????????????????????????????+
?????????????????????????????????????????????????????$8DDD8D88D88Z$7I7IIIIIIIII??I???????+?+?++++++++++++??+??????I?IIIIIII77I777777777$$$ZZO888D8DDO8DDDNND87?????????????????????????????????????????+
?????????????????????????????????????????????????????ODDNODD8D88O$777IIIIIIIII?II???????+++++++++++++++?+?+????????IIIIIIII7777777777777$7$$ZO8DODD8888NDDNND8$I???????????????????????????????????????+
????????????????????????????????????????????????????78888OO888DO$777IIIIIIIII?I????????+++++++++++++++++++++++???????IIIIIII777I777777777777$O88888O8888DNDDDDZI???????????????????????????????????????+
???????????????????????????????????????????????????IO88$8OODN8OZ777IIIIIIIIII??????+??++++++++++++++++++++++?++????????IIIIIII777I7777777777$ZZ88OOO88D8888DD887I??????????????????????????????????????+
??????????????????????????????????????????????????I7OO888888OOO$777IIIIIIII????????++++++++++++++++++++++++++++?+???????IIIIIIII7I77777777777$ZO88O8ZO88D88N8D8O7??????????????????????????????????????+
?????????????????????????????????????????????????I?I88D8OD8OOOZ777IIIIIIII???????++++++++++++++++++++++++++++++++????????IIIIII7777II77II77777$ZOOZOO88O8O8DD88OI??????????????????????????????????????+
??????????????????????????????????????????????????IZOOOZOOO$OO$7777IIIIII???????++++++++++=+++=+++=+++++++++++++++++?????IIIIIIIII7I7IIIIII777$O8ZZZO8ZZ8Z8DND8DO$?????????????????????????????????????+
??????????????????????????????????????????????????IZOZ8OZOZO8Z7777IIIIII???????++++++++=++=============+==+=++++++++++????I??III7IIIIIIIIIII77$ZOZ$ZZO8ZO$8O8DDDO7?????????????????????????????????????+
?????????????????????????????????????????????????I7O8OOZ$ZOOZ77777IIIII??????++++++=+++=====================+=++++++++????????IIIIIIIIIIIIIIII7ZOZZ$$ZZOO878DO8DDOI????????????????????????????????????+
??????????????????????????????????????????????????IZO$ZZZOZ$$$7777IIIII??????++++++==========================+++++++++?+??????I?IIIIIIIIIIIII77$ZO$ZZZ$8Z8OZ88DDO7$????????????????????????????????????+
??????????????????????????????????????????????????$$$ZO$ZZ$Z$$77IIIIIII?????++++++==============================++++++++++???????IIIIIIIIIIII77$OZZZ$8ZZO8Z$8D8D8O7?????????????????????????????????????
??????????????????????????????????????????????????$ZZOOO$I$$Z$77IIIII??????+++++++++=========================+==+++++++++++???????IIIIIIIIIIII7$Z$OZ$O$ZOZOOOO888O$????????????????????????????????????+
?????????????????????????????????????????????????7$OZOZZ$Z7$$77IIIIII??????+++++++================================+++=++++++?+????I??IIIIIIIII7$$ZZO$ZZZO$ZZ8O88D8ZI????????????????????????????????????
?????????????????????????????????????????????????7OZO$Z$$7$$$77IIIIII?I???+++++++=+===============================+++++++++????????IIIIIIIIIII7$Z$OO$OOOZOOZ8N88DOII????????????????????????????????????
?????????????????????????????????????????????????7$Z$Z$Z$77ZZ77IIIII??????+++++==================================+=+==++++??+???????IIIIIIIIII7ZZZ$ZOZZ8OOODD8888O$?????????????????????????????????????
?????????????????????????????????????????????????IOZ8$Z$77$O$77IIIII???????++++=+=+===================================+++++++??????I?I?IIIIIII7$ZOZZ$Z$ZOOO888888ZI?????????????????????????????????????
?????????????????????????????????????????????????788ZZ$77$Z$$77III????????+++++================~===================+==++++++?????????I?IIIIII77$OZZOZ7ZZ$OOZO88DZZ7?????????????????????????????????????
????????????????????????????????????????????????I7ZZ$$I7$O7$77III?I????????+++++++============~=======================++++?+??????????IIIIIII77$ZZZZ$$Z$ZZOZ8D8OOZ?I????????????????????????????????????
????????????????????????????????????????????????I7$$777$Z$$$77IIIIII???????++++++=========~====~===~==================+++++++??????????I?IIII77$ZZ$ZZ$ZZO$ZODOO8OZ?I????????????????????????????????????
????????????????????????????????????????????????I777I$$7$$Z$IIIIII????????++++++++================~===============+=+++++++++????????????IIII777$Z$$ZZ$ZZZ$O8ZZZ87I?????????????????????????????????????
?????????????????????????????????????????????????I$$77$7Z$$7IIIIII???????++++++++++===============================+++++++++++?????????????IIIII7$ZZZ$O7Z7OZ$$OZ887??????????????????????????????????????
?????????????????????????????????????????????????I$$7$77Z7$7IIII?I???????+?++++++++=============================+++++++++++++?????????????????I7$ZZ$Z$$$7$$7O$OO8Z?????????????????????????????????????+
?????????????????????????????????????????????????I7$777$7$$7IIIII???????+?++++++++==============================+++++++++++?????????????I????II77Z$$$7Z77Z$7Z$888$??????????????????????????????????????
????????????????????????????????????????????????I7$777777$$IIIII?III?????++?++++++================================++++?+++?+??????????????????III$$Z$7$$I$Z7OOZOOII?????????????????????????????????????
????????????????????????????????????????????????II$$77$$7$7IIIIIIII????????++++++++==============================+++++????????????????????????III$$$$$7$I7$7$Z$OZI??????????????????????????????????????
?????????????????????????????????????????????????7$$I77$$$IIIIIIIIIII?????++++++++++=============================++++++++????????III??????????I?I7$$$$$I$7I?ZIZZZ7?????????????????????????????????????+
?????????????????????????????????????????????????$Z$$77IZ7IIIIII7IIII????????+++++++==+=========================+++++++++????????I?IIIII????????II7$I$77I7$?Z$OOZ7I?????????????????????????????????????
????????????????????????????????????????????????II777$7$$IIIIIIIIIII????+???+++++++++===========================++++++?++????????IIIIIIIII???????II7777I77I+7$OZZZ??????????????????????????????????????
?I???????????????????????????????????????????????I$77$7$$IIIIIIIIII????????+??++++++++=+======================+=+++++++?????????I??IIIIIII?????????777I7I7I?I$$OZ7??????????????????????????????????????
?????????????????????????????????????????????????I$7$$$$$IIIIIII7II???I??????????+++++++++==================+++++++++??+???????II?IIIIIIII?????????7I$II?7?77I$OZ$??????????????????????????????????????
?????????????????????????????????????????????????I7$7$$$$IIIII7I7III7IIIIIII777777I???+?+++===========++++++++++????III?IIIIIIIIIIIIIIIIIII????????I7$$7II777I$OZ7I?????????????????????????????????????
????????????????????????????????????????????????II$$$$ZZ$IIIIII7II7I77$77$Z$ZOOOO8OZ77I???++++++===++++++++???III7$$ZZZZ7$777777II7IIIIIIII????????7$$$7I7I$778887??????????????????????????????????????
?I????????????????????????????????????????????I777$Z$Z$O$7IIIII7I777$7$77$ZZZOZZZ$Z$$7III???++++++++++?+?+???I$$$OOZOOOOOZZ$7$77$777IIII??I????????7$Z7777$7778O$I??????????????????????????????????????
?I???????????????????????????????????????????IIIII7Z$OZ8$7IIIII777Z$7$7I???++????II77777II????+??+++++??????III777$$$Z$$7I777$$77$$$7IIII??I?I?I???I$$$$$$77IO8ZI???????????????????????????????????????
?III??????????????????????????????????????????7I??I7ZOZ8$IIIII777Z$III??+?+??II7777$77II7II??????+++?????IIIII7IIIIII???+++++???I$7$$7II??I?II?????7$7ZOO7Z$ZOO$Z$$77I??????????????????????????????????
?III??????????????????????????????????????????I7I?II$ZZO77IIII7$$77II??II$$Z8DNNDNDDOII77I77I???+++++???III77II7$777$OOOO$7I????I??I77777IIIII?????7ZZ7OZ$$ZZO$$77II????????????????????????????????????
?IIII?????????????????????????????????????????I???III88O7IIII7II7?IIII$O8D8$I8DD.M.D8I7I?IIII??++===++??IIII7II?IZOI$8NNNNNDOZ$7II???IIIIIIIIII???I7ZOIZZ$7$Z$77I???O7+?????????????????????????????????
?III????????????????????????????????????????????????7Z8Z77IIIII????I7$Z$$77I+I8O8888?==+7I+?II?++++++??III7?++I7?+=~7O8NND88?$8DOO7????????I?IIIIIIIZO$Z77+777II?=+I77??????????????????????????????????
?I??????????????????????????????????????????????+?I??ZO$7IIII??????IIII?????I?II?IIIIIII77??II??++++??I7I7I+?7+I=?=~=ZO8888II7$Z8OZZII??I???III?IIIIZ$8O7$+III??==?III+?????????????????????????????????
?I??????????????????????????????????????????????????IO8$7IIII??????????+?+++++??????+?+++?IIIII???++?I77I7II?????I??II7III?I7I7II7$777I?????+??????I7$8OZ??I??I?+=III?+?????????????????????????????????
?II??????????????????????????????????????????????????$877IIIII??+??????++++++++++++++????IIIII???+???I77IIII+?+?????????????????IIII7IIII???II??????77OZ$?I?III?+?II????????????????????????????????????
?III???????????????????????????????????????????????+??Z77IIIII?I?+??++++++?+++++?????????IIII7I?????II777I?I?????????++++++++?????????III???????????I7O$???IIIII??7II???????????????????????????????????
?III????I??????????????????????????????????????????+++I77IIIII????++++++++++++++++++++??III7II?????III7777I????????????+??+??????????????????I???????77I??7IIIIII?77?+??????????????????????????????????
?IIIII??I????????????????????????????????????????I?+?+I77III???????++++++++++++++++++???I77III?I????II7777I??????????????????????????+???I????????????I??7$777III?7I?+??????????????????????????????????
?IIIIIII?????????????????????????????????????????II??II77III???I??++++++++++++++++++++?I7IIIIIIIIIIIII777$7II????????????++++++++++++????????????++??????$777II???7?????????????????????????????????????
?IIIIIII??????????????????????????????????????????I??II77I????????++++++++++++++++++??IIIIIIIII?I?III7I77777I??????????++++++++++++++????????I???++??????7777II?I?I?+???????????????????????????????????
?IIIIIIIIIII???????????????????????????????????????????77I????????+++++++++++++++++??IIIIIIIIIII?IIIII7777777????++++++?+?+++++??++?????????????++??????+77777I?+7?+????????????????????????????????????
?IIIIIIIIIIII??????????????????????????????????????????I7I???????++++++++++++++++++?IIIIIIIII????IIIII7777777II??+++++++++++++++++++?+??????????+???????I77$$I7I?I+?????????????????????????????????III?
?IIIIIIIIIIII??I??????????????????????????????????????+?7I????????++++++++=++++++++???III7I?I?????IIII777777III???+++++++++++++++++++?????????+++??????I7$Z$$7I?7????????????????????????????III???IIII?
?IIIIII?IIIIIIIII?????????????????????????????????????+?7II??????+?+++++++===+=+++???I7IIII????????III7777777I???+++++++++++++++++++?????????++++??????Z$777II+7???????????????????????II???IIII??IIIII?
?IIIIIIIIIIII????I?????????????????????????????????????+77I???????+++++++====++++??I77II7II????+????III7777777I???++++++++++++++++++++??????++++???????$77I???7I??????????????????????IIIIIIIIIIIIIIIII?
?IIIIIIIIIIII???III?????????????????????????????????????I7II?????++++++++=++++++??I77IIIII?????+???IIII777777$$7???++++++++++++++++?+?????++++++??????IIII??77I?????????????????IIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIII??II????????????????????????????????I????77III?????+++++++++++??III7III7III???+???IIIIII7777$7$$I???++++++++++++++??????+++++++?????+?II77?I7I+??????????????III?IIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIII??I????????????????????????????????I????77I?II????++++++++???IIIIIIIIIIII?+++++??????IIIIII777$$I????+?+++++++++++????++++++++++???+7II7II?I+???????????????IIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIII???I???????????????????????????????II???77II????????++?+???II77IIIIIIIIII??+++++++??????IIIIII$7II????++++++++++++????++++=++++++??$77?77I?????????????????IIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIII????????????????????????????????????I??II7II????????????II7$7IIIIII77III7II??++??????IIII??I?7$7II?????????+??+??????++++++++++++?+Z77IIIII??????????I???IIIIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIIII??I?????????????????????????????????I7$77IIII????????III$7I?IIIIIII77$$77II?????IIIIII7$Z$$$$77II?IIIIIII???????????+++++++++++++?O$7??II+????????I?I?IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIIIIIIII????????????????????????????????????7IIII???????I7$?????IIIIII77I7$$$777777I7$$$$$7$7$77IIIIIIIII??????I77I?I???++++++++++++??7$7I??+?????IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIIIIIIIIII????????????????????????????????I?I7III???????7I??++??II?III7777777$77I77777$777777777II7IIIII?II????++?77I????++++++++++????7Z7II??IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIIIIIIIIII???????????????????????????????????7III?I?+++?I+??++???IIIIIII7II77III??IIIIIII7II77777IIIIII????????+++?I7???++++++++++++I??I????I??IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIIIIIIIII?IIIII??????????????????????????????IIII???++++?++?II???III7IIIIIII????+?++?+???III777I7II7IIIII????I?I?++?7???+++++++++?+?I???I?IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIIIIIIIIIIIIIIII?????????????????????????????I7II??I?+==++++?+?I??IIIIIII????++++++++++?+???IIIIIIIIIIIIIII7I????++?II?+++?+++++???I????I?IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?????????????????????????I?I7I?I??I?+==+=+?++IODZIIIIII?I??+?+++++++++++??I??IIIIII777$8OI??+?+++?II?+?+I++?+??????II?I?IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
?IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII??????????????????IIII????I7I??+?I++====+?+??7N8OZ$77III??+++++++++++++????III7$ZOOODI??+++++++?7?+????++??????I?IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII????????????????????I??III7II?++I?+++==+?++??IODI?I=?7I777I??????IIII77777I$$$$IDZ7????+?++==+?7?++?I++?????+???IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII??????????III?I?IIIIII?I7II?++I?+++++++++???IOI?+~+~~?===?77I?++7?==7+~+$?77$I???????+++=++I?+++???????????IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII??????????IIIIIIIIIIIIII7II?++?I?+++++++??????I$??=~:=~~::=~:~:~?~~~?~=+777???????????++=++7+++??????I?????IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII??????????IIIIIIIIIIIIIII7II?++?I?+++++++???I????I?+~?=~~~=~~~~=?=~+?I7I?+?IIII??????+++=+I?++?????II???I??IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?IIIIIIIIIIIIIIIII??7II??++?I?++++++????II????IIII?+=?=++?IIIIII???I??III??????+++=++7++???????II?7+??IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII77I??+?I???+++????IIIII?????????????+???????I??????????????++++I?++?????III??++??IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7II??+?I???+++????I?I?I????+++++++++++???I?I????????????+++++?I++????IIIII??++??IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?77II???I??++?+?????????II??????????????III???????????????++++7++?+??III?I??++???IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7II????I??+??+++????????????IIIIIIIII???????????????????+++?I++???II?I?II?++???IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7II???II?????+???????++???II??????????+???????????????????I?++???II?II??++????IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7I????I??+??+++?+??++++++I????????+?++????????????????+?+?+????IIIII??++????IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII?I77II?II??????++++?+++++++????????++++?+????????????????+?+++?????II??+++????IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7II?III?????++++++++++++????????++++?????????I??????+++??+?????II???++I???IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7IIIIII????+++++++++++?+????????++++++???????????+?++?++?????III??????????I###ZIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII77IIIII?????+++++++++++??+??+???+++++???+???????+++?+?+?????IIII??????+????#####OIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII777IIII?????+++++?++?+???????????++?+??????????++???+++????7III????????????#######ZIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII77777III???+?+??++???++?+???+?????????????????????+?+?+??II?III?I?I+?+?+??I########OIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII77I$777II??+????????????????????????????????????+++?+??II7IIIIIII???+?+??I$O########ZIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII77I7$77II??????+????????????????????????????????+??+?III7777IIII????????I7ZO########OIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII77II7$77II??????????????????+???????????????????????II7$7777III???I?I?II7$ZO#########$IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIO#77I7$$77I????????????++??++????????????????????I?II7$$7777III??II?IIII77$ZO#########OIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII###$7II7$$$7II?????+++?++??+++?++?+??+??????????IIII$$Z$$777III??I?????III77ZO##########$IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7####Z7III7$$$7I?????????+++?+++????++??+???????III77ZZ$$77IIIII????????III777ZO##########OIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIZ######77III7$7$$7II?????++???++++++??+?????III7777$Z$$$77IIII????????????III7$Z#############7IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7#######77III7$77$$$7IIII???????+++++??????III77$$ZZ$$777IIIII???????????????I77##############OO7IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII########$7III777III7$$77I?II?????????IIIII777$$$Z$$$77IIIIIII????+?+????????III$#################OO7IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII##########7IIII777IIIII7$Z777II?IIIIIII777$$ZZ$$$$777IIIII???????++++??+???????IO#####################IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7Z###########77II777II??IIII777$ZZ$7$77$$$$77777777777II?????????+++++++++????????$######################O7IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7Z###############77II777II??????I?III?????+????IIIIIIIII7II????????+?++++++++++++++??7Z#######################ZIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7$###################77III77II??++??????++++++++++?????????I????+++??++++++++++++++++++?I$########################OO$IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7$Z######################Z77III777II?++??+++++++=+++++++?????????????+++++++++++++++++++++++?$############################O$IIIIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7$O###########################?$7IIII777I?+?+++++++=+=++++++++????????++++++++++++++++++++++++++?7################################$IIIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII7Z################################+Z7IIII777II?++++=+++++=++++++?++??++++++++=+++++++++++++++++++++?7##################################OZIIIIIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII$O###################################Z?Z$7IIII777I?++++===+++++++++++++++++++=====++++++=+++++++++++++I$#######################################7IIIIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII$#######################################IIZ$7IIIII777I??++==+++++++++++++++?++++=====+=+=+=+++++++=+++++?$#########################################O7IIIIIIIIIIIIIIIIIIII
IIIIIIIIIIIIIIIIIIIIIIIIIIII$##########################################?IZ$7IIIII77I7I?+++++++?+++???++??++++==========++++++++===+++?IZ############################################ZIIIIIIIIIIIIIIIII7I
IIIIIIIIIIIIIIIIIIIIIIIII$O############################################?IO77IIIIII7777?+++++????????+++++++++++=========+++=++++===+?IO##############################################O$7II7IIIIIIIIII77I
IIIIIIIIIIIIIIIIIIIIII7Z###############################################?I#77II???II7777I???????++++++++++++++=========++++++++====+?I#################################################ZOZ7III7IIIII7I77I
IIIIIIIIIIIIIIIIIII7$O#################################################??#$77I???IIII777I????+++++++++++++++=+=======++++++++==+=+?I###################################################O#OZ7777IIIIII7II
IIIIIIIIIIIIIIIII7Z####################################################$+#$77II???IIIII77II????+++++++++++++======+===+++++++==++?I########################################################OZ7777777I77I
IIIIIIIIIIIIIII$O#######################################################=#Z77II????IIIIIIIII????++++++++++==========+=++=+++==++?7###########################################################OZ$I777777I
IIIIIIIIIIII7Z##########################################################=Z#777I??????IIIIIIII???++++++++++=====+++=======+=+=+??Z##############################################################ZZ$III77I
IIIIIIIIII7Z############################################################I+#777II?????I?I??????++++++++++=+=========++=+++++++??#################################################################ZZZZ777I";
    }
}
