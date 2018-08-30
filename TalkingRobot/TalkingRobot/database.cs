using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkingRobot
{
    class database
    {
        private string image_path, image_description;
          private database[] fruits;
          private database[] colors;
          private database[] flags;
          private database[] animals;
          private database[] number;

        

        public database()
        {
            fruits = new database[26];
            colors = new database[7];
            flags = new database[26];
            animals = new database[26];
            number = new database[10];
        }

        public void init_database_number()
        {
            for (int i = 0; i <= 9; i++)
            {
                number[i] = new database();
            }

            number[0].image_description = "O,N ,E,  IS ONE .";
            number[0].image_path ="1";

            number[1].image_description = " T,W ,O  , IS TWO .";
            number[1].image_path = "2";

            number[2].image_description = " T,H,R,E,E , IS THREE .";
            number[2].image_path = "3";

            number[3].image_description = "F,O,U,R  IS FOUR.";
            number[3].image_path = "4";

            number[4].image_description = " F,I,V,E, IS FIVE.";
            number[4].image_path ="5";

            number[5].image_description = "S,I,X, IS SIX.";
            number[5].image_path = "6";

            number[6].image_description = "S,E,V,E,N, IS SEVEN.";
            number[6].image_path = "7";

            number[7].image_description = "E,I,G,H,T, IS EIGHT.";
            number[7].image_path = "8";

            number[8].image_description = "N,I,N,E, IS NINE.";
            number[8].image_path = "9";

            number[9].image_description = "T,E,N, IS TEN .";
            number[9].image_path = "10";



        }
        public string get_number_description(int i)
        {
            return number[i].image_description;
        }

        public string get_number_image_path(int i)
        {
            return number[i].image_path;

        }
        public void init_database_animals()
        {
            for (int i = 0; i <= 25; i++)
            {
                animals[i] = new database();
            }

            animals[0].image_description = "A , FOR  , ANT .";
            animals[0].image_path = @"animal_images\ant.png";

            animals[1].image_description = "B , FOR  , BEAR .";
            animals[1].image_path = @"animal_images\bear.png";

            animals[2].image_description = "C , FOR  , CAT .";
            animals[2].image_path = @"animal_images\cat.png";

            animals[3].image_description = "D , FOR  , DOG .";
            animals[3].image_path = @"animal_images\dog.png";

            animals[4].image_description = "E , FOR  , EAGLE .";
            animals[4].image_path = @"animal_images\eagle.png";

            animals[5].image_description = "F , FOR  , FROG .";
            animals[5].image_path = @"animal_images\frog.png";


            animals[6].image_description = "G , FOR  , GORILLA .";
            animals[6].image_path = @"animal_images\gorilla.png";

            animals[7].image_description = "H , FOR  , HORSE .";
            animals[7].image_path = @"animal_images\horse.png";

            animals[8].image_description = "I , FOR  , IGUANA .";
            animals[8].image_path = @"animal_images\iguana.png";

            animals[9].image_description = "J , FOR  , JACKAL .";
            animals[9].image_path = @"animal_images\jackal.png";

            animals[10].image_description = "K , FOR  , KANGAROO .";
            animals[10].image_path = @"animal_images\kangaroo.png";

            animals[11].image_description = "L , FOR  , LION .";
            animals[11].image_path = @"animal_images\lion.png";

            animals[12].image_description = "M , FOR  , MONKEY .";
            animals[12].image_path = @"animal_images\monkey.png";

            animals[13].image_description = "N , FOR  , NUMBAT .";
            animals[13].image_path = @"animal_images\Numbat.png";

            animals[14].image_description = " O , FOR  , OSTRICH .";
            animals[14].image_path = @"animal_images\ostrich.png";

            animals[15].image_description = "P , FOR  , PENGIUN .";
            animals[15].image_path = @"animal_images\pengiuun.png";

            animals[16].image_description = "Q , FOR  , QUOKKA .";
            animals[16].image_path = @"animal_images\quokka.png";

            animals[17].image_description = "R , FOR  , RABBIT .";
            animals[17].image_path = @"animal_images\rabbit.png";

            animals[18].image_description = "S , FOR  , SHEEP .";
            animals[18].image_path = @"animal_images\sheep.png";

            animals[19].image_description = "T , FOR  , TIGER .";
            animals[19].image_path = @"animal_images\tiger.png";

            animals[20].image_description = "U , FOR  , UMBRELLA BIRD .";
            animals[20].image_path = @"animal_images\umbrella.jpg";

            animals[21].image_description = "V , FOR  , VULTURE .";
            animals[21].image_path = @"animal_images\vulture.png";

            animals[22].image_description = "W , FOR  , WOLF .";
            animals[22].image_path = @"animal_images\wolf.png";

            animals[23].image_description = "X , FOR  , X - RAY TETRA .";
            animals[23].image_path = @"animal_images\xraytetra.png";

            animals[24].image_description = "Y , FOR  , YAK .";
            animals[24].image_path = @"animal_images\yalk.png";

            animals[25].image_description = "Z , FOR  , ZEBRA .";
            animals[25].image_path = @"animal_images\zebra.png";

        }
        public string get_animals_description(int i)
        {
            return animals[i].image_description;
        }

        public string get_animals_image_path(int i)
        {
            return animals[i].image_path;

        }


        public void init_database_flags()
        {
            for (int i = 0; i <= 25; i++)
            {
                flags[i] = new database();
            }

            flags[0].image_description ="A , FOR  , AUSTRALIA .";
            flags[0].image_path = @"flag_images\australia.gif";

            flags[1].image_description = "B , FOR  , BANGLADESH .";
            flags[1].image_path = @"flag_images\bangladesh.gif";

            flags[2].image_description = "C , FOR  , CHINA .";
            flags[2].image_path = @"flag_images\china.gif";

            flags[3].image_description = "D , FOR  , DENMARK .";
            flags[3].image_path = @"flag_images\denmark.gif";

            flags[4].image_description = "E , FOR  , EGYPT .";
            flags[4].image_path = @"flag_images\egypt.gif";

            flags[5].image_description = "F , FOR  , FRANCE .";
            flags[5].image_path = @"flag_images\france.gif";


            flags[6].image_description = "G , FOR  , GERMANY .";
            flags[6].image_path = @"flag_images\germany.gif";

            flags[7].image_description = "H , FOR  , HONG KONG .";
            flags[7].image_path = @"flag_images\hong_kong.gif";

            flags[8].image_description = "I , FOR  , INDIA .";
            flags[8].image_path = @"flag_images\india.png";

            flags[9].image_description = "J , FOR  , JAPAN .";
            flags[9].image_path = @"flag_images\japan.gif";

            flags[10].image_description = "K , FOR  , KUWAIT .";
            flags[10].image_path = @"flag_images\kuwait.gif";

            flags[11].image_description = "L , FOR  , MALAYSIA .";
            flags[11].image_path = @"flag_images\malaysia.gif";

            flags[12].image_description = "M  .";
            flags[12].image_path = @"flag_images\nop.gif";

            flags[13].image_description = "N , FOR  , NEPAL .";
            flags[13].image_path = @"flag_images\nepal.gif";

            flags[14].image_description = " O , FOR  , OMAN .";
            flags[14].image_path = @"flag_images\oman.gif";

            flags[15].image_description = "P , FOR  , PAKISTAN .";
            flags[15].image_path = @"flag_images\pakistan.gif";

            flags[16].image_description = "Q , FOR  , QATAR .";
            flags[16].image_path = @"flag_images\qatar.gif";

            flags[17].image_description = "R , FOR  , REUNION .";
            flags[17].image_path = @"flag_images\reunion.gif";

            flags[18].image_description = "S , FOR  , SAHARA .";
            flags[18].image_path = @"flag_images\sahara.gif";

            flags[19].image_description = "T , FOR  , THAILAND .";
            flags[19].image_path = @"flag_images\thailand.gif";

            flags[20].image_description = "U , FOR  , UGANDA .";
            flags[20].image_path = @"flag_images\uganda.gif";

            flags[21].image_description = "V , FOR  , VATICAN .";
            flags[21].image_path = @"flag_images\vatican.gif";

            flags[22].image_description = "W  .";
            flags[22].image_path = @"flag_images\nop.png";

            flags[23].image_description = "X .";
            flags[23].image_path = @"flag_images\nop.png";

            flags[24].image_description = "Y , FOR  , YEMEN .";
            flags[24].image_path = @"flag_images\yemen.gif";

            flags[25].image_description = "Z , FOR  , ZIMBABWE .";
            flags[25].image_path = @"flag_images\zimbabwe.gif";

        }
        public string get_flags_description(int i)
        {
           return flags[i].image_description;
            //return "PLACE";
        }

        public string get_flags_image_path(int i)
        {
            return flags[i].image_path;

        }
         public void init_database_colors()
        {
            for (int i = 0; i <= 6; i++)
            {
                colors[i] = new database();
            }

            colors[0].image_description = " THIS , IS , VIOLET , COLOR .";
            colors[0].image_path = @"color_images\violet.png.png";

            colors[1].image_description = " THIS , IS , INDIGO  , COLOR .";
            colors[1].image_path = @"color_images\indigo.png";

            colors[2].image_description = " THIS , IS , BLUE , COLOR .";
            colors[2].image_path = @"color_images\blue.png";

            colors[3].image_description = " THIS , IS , GREEN , COLOR .";
            colors[3].image_path = @"color_images\grreen.png";

            colors[4].image_description = " THIS , IS , YELLOW , COLOR .";
            colors[4].image_path = @"color_images\yellow.png";

            colors[5].image_description = " THIS , IS , ORANGE , COLOR .";
            colors[5].image_path = @"color_images\orange.png";

            colors[6].image_description = " THIS , IS , RED ,  COLOR .";
            colors[6].image_path = @"color_images\red.png";

        }
         public string get_colors_description(int i)
         {
             return colors[i].image_description;
         }

         public string get_colors_image_path(int i)
         {
             return colors[i].image_path;

         }
        public void init_database_fruits()
        {
             for (int i = 0; i <= 25; i++)
             {
                 fruits[i] = new database();
             }

                fruits[0].image_description = "A , FOR  , APPLE .";
                fruits[0].image_path = @"fruit_images\apple.png";

                fruits[1].image_description = "B , FOR  , BANANA .";
                fruits[1].image_path = @"fruit_images\banana.png";

                fruits[2].image_description = "C , FOR  , CHERRY .";
                fruits[2].image_path = @"fruit_images\cherry.png";

                fruits[3].image_description = "D , FOR  , DATES .";
                fruits[3].image_path = @"fruit_images\dates.png";

                fruits[4].image_description = "E , FOR  , EGG PLANT .";
                fruits[4].image_path = @"fruit_images\eggplant.png";

                fruits[5].image_description = "F , FOR  , FIG .";
                fruits[5].image_path = @"fruit_images\fig.png";


                fruits[6].image_description = "G , FOR  , GRAPES .";
                fruits[6].image_path = @"fruit_images\grape.png";

                fruits[7].image_description = "H , FOR  , HUCKLE BERRY .";
                fruits[7].image_path = @"fruit_images\huckleberry.png";

                fruits[8].image_description = "I , FOR  , IMBE .";
                fruits[8].image_path = @"fruit_images\Imbe.jpg";

                fruits[9].image_description = "J , FOR  , JACK FRUIT .";
                fruits[9].image_path = @"fruit_images\jackfruit.png";

                fruits[10].image_description = "K , FOR  , KIWI .";
                fruits[10].image_path = @"fruit_images\kiwi.png";

                fruits[11].image_description = "L , FOR  , LEMON .";
                fruits[11].image_path = @"fruit_images\lemon.png";

                fruits[12].image_description = "M , FOR  , MANGO .";
                fruits[12].image_path = @"fruit_images\mango.png";

                fruits[13].image_description = "N , FOR  , NARAN JILLO .";
                fruits[13].image_path = @"fruit_images\naranjillo.png";
            
                fruits[14].image_description = " O , FOR  , ORANGE .";
                fruits[14].image_path = @"fruit_images\orange.png";

                fruits[15].image_description = "P , FOR  , PEAR .";
                fruits[15].image_path = @"fruit_images\pear.png";

                fruits[16].image_description = "Q , FOR  , QUANDONG .";
                fruits[16].image_path = @"fruit_images\quandong.jpg";

                fruits[17].image_description = "R , FOR  , RASPBERRY .";
                fruits[17].image_path = @"fruit_images\raspberry.png";

                fruits[18].image_description = "S , FOR  , STRAWBERRY .";
                fruits[18].image_path = @"fruit_images\strawberry.png";

                fruits[19].image_description = "T , FOR  , TAMARILLO .";
                fruits[19].image_path = @"fruit_images\tamarillo.png";

                fruits[20].image_description = "U , FOR  , UGNI .";
                fruits[20].image_path = @"fruit_images\ugni.jpg";

                fruits[21].image_description = "V , FOR  , VANILLA BEANS .";
                fruits[21].image_path = @"fruit_images\vanilla.jpg";

                fruits[22].image_description = "W , FOR  , WATER MELON .";
                fruits[22].image_path = @"fruit_images\watermelon.png";

                fruits[23].image_description = "X  .";
                fruits[23].image_path = @"fruit_images\nop.png";

                fruits[24].image_description = "Y , FOR  , YELLOW MOMBIN .";
                fruits[24].image_path = @"fruit_images\Yellowmombin.jpg";

                fruits[25].image_description = "Z , FOR  , ZIG ZAG WINE .";
                fruits[25].image_path = @"fruit_images\zigzagwine.jpg";


            
            
        }

       public string  get_fruit_description(int i)
        {
                return fruits[i].image_description;
       }

       public string get_fruit_image_path(int i)
       {
               return fruits[i].image_path;
           
       }

        


      
    }
}
