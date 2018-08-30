using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.IO;
using System.Reflection;


namespace TalkingRobot
{
    public partial class Display : Form
    {
        private Thread thread=null;

        private Choices sList = new Choices();
        private Grammar gr;
        private SpeechRecognitionEngine recognize = new SpeechRecognitionEngine();
       private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
       private PromptBuilder pBuilder = new PromptBuilder();
       private database db_fruits;//db_animals,db_flags;
       private database db_colors=null;
       private database db_flags=null;
       private database db_animals=null;
       private database db_number = null;

       private bool paus_play_status = false;
       private bool repeat_flag = false;
       private int repeat_cnt = 1;
       private string username;
       private Thread date_thread_start;
       private bool jump_flag=false;
       private int jump_to = 0;
         



        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            try
            
            {
                db_fruits = new database();
                db_fruits.init_database_fruits();

                db_colors = new database();
                db_colors.init_database_colors();

                db_flags = new database();
                db_flags.init_database_flags();

                db_animals = new database();
                db_animals.init_database_animals();

                db_number = new database();
                db_number.init_database_number();


                ThreadStart date_thread = new ThreadStart(this.date_Time_thread);
                 date_thread_start= new Thread(date_thread);
                date_thread_start.Start();

                

                ThreadStart tts = new ThreadStart(TextToSpeech);
                Thread threadtts = new Thread(tts);
                threadtts.Start();

                ThreadStart stt = new ThreadStart(SpeechToText);
                Thread threadstt = new Thread(stt);
                threadstt.Start();

               
            }
            catch(Exception ex)
            {
              //  MessageBox.Show(ex.StackTrace);
            }
            
            


        }

        private void  date_Time_thread()
        {
            while(true){
                try
                {
                    date_time.Invoke((Action)delegate
                    {
                        System.DateTime date = System.DateTime.Now;
                        date_time.Text = "" + date.ToLongDateString()+ " : "+date.ToLongTimeString();
                        date_time.Refresh();
                    });
                    
                }
                catch(Exception ex)
                {
                   // MessageBox.Show(""+ex);
                }
               }
        }
        private void SpeechToText()
        {

            //speech to text

          
            sList.Add(new string[] { 
            "good bye",
                "hello",
            "change it",
            "test",
            "it works",
            "exit",
            "bye",
            "tell your name",
            "jarvis dont dance",
            "what is your name"
            
            
            });
             gr = new Grammar(new GrammarBuilder(sList));

            try
            {
                 
                 recognize = new SpeechRecognitionEngine();
                recognize.RequestRecognizerUpdate();
                recognize.LoadGrammar(gr);
                recognize.SpeechRecognized += recognize_SpeechRecognized;
                recognize.SetInputToDefaultAudioDevice();
                recognize.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch(Exception ex) {
               // MessageBox.Show(ex.StackTrace);

                 }
        }

        private  void recognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                if (e.Result.Text == "exit" || e.Result.Text == "good bye" || e.Result.Text == "bye")
                {
                    pBuilder.ClearContent();
                    pBuilder.AppendText("good bye sir ");
                    synthesizer.Speak(pBuilder); // text to speeech code
                    Application.Exit();
                }
                else
                    if (e.Result.Text == "tell your name" || e.Result.Text == "what is your name")
                    {
                        pBuilder.ClearContent();
                        pBuilder.AppendText("MY NAME IS JARVIS \n I HAVE BEEN PROGRAMMED TO TEACH");
                        synthesizer.Speak(pBuilder); // text to speeech code
                    }
                    else
                        if (e.Result.Text == "jarvis dont dance")
                        {
                            pBuilder.ClearContent();
                            pBuilder.AppendText("I AM NOT DANCING SIR \n ");
                            synthesizer.Speak(pBuilder); // text to speeech code
                        }

            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void TextToSpeech()
        {
            try
            {
                Thread.Sleep(500);


                pBuilder.ClearContent();
                pBuilder.AppendText("HELLO I AM JARVIS");
                synthesizer.Speak(pBuilder); // text to speeech code
                if (System.DateTime.Now.Hour >= 1 && System.DateTime.Now.Hour < 6)
                {
                    Thread.Sleep(30);
                    pBuilder.ClearContent();
                    pBuilder.AppendText("good night  ,"+username);
                    synthesizer.Speak(pBuilder);
                }
                else
                    if (System.DateTime.Now.Hour >= 6 && System.DateTime.Now.Hour < 12)
                    {
                        Thread.Sleep(30);
                        pBuilder.ClearContent();
                        pBuilder.AppendText("good morning ,"+username);
                        synthesizer.Speak(pBuilder);
                    }
                    else
                        if (System.DateTime.Now.Hour >= 12 && System.DateTime.Now.Hour < 16)
                        {
                            Thread.Sleep(30);
                            pBuilder.ClearContent();
                            pBuilder.AppendText("good afternoon ,"+username);
                            synthesizer.Speak(pBuilder);
                        }
                        else
                            if (System.DateTime.Now.Hour >= 16 && System.DateTime.Now.Hour < 21)
                            {
                                Thread.Sleep(30);
                                pBuilder.ClearContent();
                                pBuilder.AppendText("good evening ,"+username);
                                synthesizer.Speak(pBuilder);
                            }
                            else
                            {
                                Thread.Sleep(30);
                                pBuilder.ClearContent();
                                pBuilder.AppendText("what happen  "+username);
                                synthesizer.Speak(pBuilder);
                            }
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.StackTrace);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.StackTrace);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                pBuilder.ClearContent();
                pBuilder.AppendText("DONT TOUCH ME");
                synthesizer.Speak(pBuilder);
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.StackTrace);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if (thread !=null)
            {
                thread.Abort();
            }
            pBuilder.ClearContent();
            if (user_name.Text.Length == 0 || user_name.Text == "enter your name")
            {
                user_name.Text = "enter your name";
                MessageBox.Show("ENTER YOUR NAME ", "NAME", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            username = user_name.Text;
            pBuilder.AppendText("LEARN  , ALPHA,BETS , a to  z  ," + username);
            synthesizer.SelectVoiceByHints(VoiceGender.Male);
            synthesizer.Speak(pBuilder);

           thread =new Thread(new ThreadStart(this.learn_abcd_thread));
            thread.Start();    
        }

       public void learn_abcd_thread()
        {
        
            try
            {
                string image_path = null, image_tell = null;
                int i = 0;
                pBuilder.ClearContent();


                // this.image_type = System.Windows.Forms.ImageLayout.Zoom;

                synthesizer.SelectVoiceByHints(VoiceGender.Female);
                information_number.Invoke((Action)delegate
                {
                    information_number.Visible = false;

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = false;

                });
                image_type.Invoke((Action)delegate
                {
                    image_type.Visible = true;

                });
                button5.Invoke((Action)delegate
                {
                    button5.Visible = false;

                });
                button8.Invoke((Action)delegate
                {
                    button8.Visible = false;

                });

                if (jump_flag == true)
                {
                    i = jump_to;
                    jump_flag = false;
                }


                for (i = 0; i <= 25; i++)
                {

                     if(jump_flag==true)
                     {
                         i = jump_to;
                         jump_flag = false;
                     }

                REPEAT: 
                BACK: if (paus_play_status == true)
                    {
                        
                            button7.Invoke((Action)delegate
                            {
                                button7.Text = "PLAY";
                                button7.Refresh();


                            });
                            goto BACK;

                   }
                     else if (paus_play_status==false)
                            {

                                button7.Invoke((Action)delegate
                                {
                                    button7.Text = "PAUSE";
                                    button7.Refresh();


                                });
                            }
                                      
                        pBuilder.ClearContent();

                        image_tell = db_fruits.get_fruit_description(i);
                        image_path = db_fruits.get_fruit_image_path(i);

                        information.Invoke((Action)delegate
                        {
                            information.Text = image_tell;
                        });
                        image_type.Invoke((Action)delegate
                        {
                            image_type.BackgroundImage = Image.FromFile(image_path);

                        });




                        pBuilder.AppendText(image_tell);
                        synthesizer.Speak(pBuilder);
                        
                      if(repeat_flag==true)
                      {
                          if (repeat_cnt == int.Parse(repeat_texboxt.Text))
                          {
                              repeat_flag = false;
                              repeat_cnt = 0;
                          }
                          repeat_cnt++;
                          goto REPEAT;
                      }
                    }



                information.Invoke((Action)delegate
                {
                    information.Text ="TALKING ROBOT";

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = true;

                }); image_type.Invoke((Action)delegate
                {
                    image_type.Visible = false;

                }); button5.Invoke((Action)delegate
                {
                    button5.Visible = true;

                }); button8.Invoke((Action)delegate
                {
                    button8.Visible = true;

                });

            }
           catch(Exception e)
            {
               // MessageBox.Show("" + e);
            }
               
        }


        

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (thread != null)
                {
                    thread.Abort();
                }
                date_thread_start.Abort();
                
                pBuilder.ClearContent();
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string blackBoardContent = richTextBox1.Text;
                pBuilder.ClearContent();
                pBuilder.AppendText(blackBoardContent);
                synthesizer.SelectVoiceByHints(VoiceGender.Female);
                synthesizer.Speak(pBuilder);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                richTextBox1.Text = "WRITE HERE..";
                richTextBox1.ZoomFactor = 3;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                if (button7.Text =="PAUSE")
                {
                    paus_play_status = true;
                }
                 if(button7.Text=="PLAY")
                 {
                     paus_play_status = false;

                 }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void repeat_button_Click(object sender, EventArgs e)
        {
            repeat_flag = true;
             //repeat_cnt = int.Parse(repeat_texboxt.Text);

        }

        private void color_button_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            } pBuilder.ClearContent();
            if (user_name.Text.Length == 0 || user_name.Text == "enter your name")
            {
                user_name.Text = "enter your name";
                MessageBox.Show("ENTER YOUR NAME ", "NAME", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            username = user_name.Text;
            pBuilder.AppendText("LEARN  , VIBGYOUR ,COLORS, " + username);
            synthesizer.SelectVoiceByHints(VoiceGender.Male);
            synthesizer.Speak(pBuilder);

            thread = new Thread(new ThreadStart(this.learn_abcd_colors));
            thread.Start();
            

        }
        public void learn_abcd_colors()
        {

            try
            {
                string image_path = null, image_tell = null;
                int i = 0;
                pBuilder.ClearContent();


                // this.image_type = System.Windows.Forms.ImageLayout.Zoom;

                synthesizer.SelectVoiceByHints(VoiceGender.Female);
                information_number.Invoke((Action)delegate
                {
                    information_number.Visible = false;

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = false;

                });
                image_type.Invoke((Action)delegate
                {
                    image_type.Visible = true;

                });
                button5.Invoke((Action)delegate
                {
                    button5.Visible = false;

                });
                button8.Invoke((Action)delegate
                {
                    button8.Visible = false;

                });




                for (i = 0; i <= 6; i++)
                {

                REPEAT:
                BACK: if (paus_play_status == true)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PLAY";
                            button7.Refresh();


                        });
                        goto BACK;

                    }
                    else if (paus_play_status == false)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PAUSE";
                            button7.Refresh();


                        });
                    }

                    pBuilder.ClearContent();

                    image_tell = db_colors.get_colors_description(i);
                    image_path = db_colors.get_colors_image_path(i);


                    information.Invoke((Action)delegate
                    {
                        information.Text = image_tell;
                    });
                    image_type.Invoke((Action)delegate
                    {
                        image_type.BackgroundImage = Image.FromFile(image_path);

                    });




                    pBuilder.AppendText(image_tell);
                    synthesizer.Speak(pBuilder);

                    if (repeat_flag == true)
                    {
                        if (repeat_cnt == int.Parse(repeat_texboxt.Text))
                        {
                            repeat_flag = false;
                            repeat_cnt = 0;
                        }
                        repeat_cnt++;
                        goto REPEAT;
                    }
                }



                information.Invoke((Action)delegate
                {
                    information.Text = "TALKING ROBOT";

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = true;

                }); image_type.Invoke((Action)delegate
                {
                    image_type.Visible = false;

                }); button5.Invoke((Action)delegate
                {
                    button5.Visible = true;

                }); button8.Invoke((Action)delegate
                {
                    button8.Visible = true;

                });
            }
            catch (Exception e)
            {
                //MessageBox.Show("" + e);
            }

        }

        private void flags_Button_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            } pBuilder.ClearContent();
            if (user_name.Text.Length == 0 || user_name.Text == "enter your name")
            {
                user_name.Text = "enter your name";
                MessageBox.Show("ENTER YOUR NAME ", "NAME", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            username = user_name.Text;
            pBuilder.AppendText("LEARN ,FLAGS , A to Z," + username);
            synthesizer.SelectVoiceByHints(VoiceGender.Male);
            synthesizer.Speak(pBuilder);

            thread = new Thread(new ThreadStart(this.learn_abcd_flags));
            thread.Start();


        }
        public void learn_abcd_flags()
        {

            try
            {
                string image_path = null, image_tell = null;
                int i = 0;
                pBuilder.ClearContent();


                // this.image_type = System.Windows.Forms.ImageLayout.Zoom;

                synthesizer.SelectVoiceByHints(VoiceGender.Female);
                information_number.Invoke((Action)delegate
                {
                    information_number.Visible = false;

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = false;

                });
                image_type.Invoke((Action)delegate
                {
                    image_type.Visible = true;

                });
                button5.Invoke((Action)delegate
                {
                    button5.Visible = false;

                });
                button8.Invoke((Action)delegate
                {
                    button8.Visible = false;

                });



                if (jump_flag == true)
                {
                    i = jump_to;
                    jump_flag = false;
                }
                for (i = 0; i <= 25; i++)
                {
                    if (jump_flag == true)
                    {
                        i = jump_to;
                        jump_flag = false;
                    }

                REPEAT:
                BACK: if (paus_play_status == true)
                    {
                     

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PLAY";
                            button7.Refresh();


                        });
                        goto BACK;

                    }
                    else if (paus_play_status == false)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PAUSE";
                            button7.Refresh();


                        });
                    }

                    pBuilder.ClearContent();

                    image_tell = db_flags.get_flags_description(i);
                     
                    image_path = db_flags.get_flags_image_path(i);


                    information.Invoke((Action)delegate
                    {
                        information.Text = image_tell;
                    });
                    image_type.Invoke((Action)delegate
                    {
                        image_type.BackgroundImage = Image.FromFile(image_path);

                    });




                    pBuilder.AppendText(image_tell);
                    synthesizer.Speak(pBuilder);

                    if (repeat_flag == true)
                    {
                        if (repeat_cnt == int.Parse(repeat_texboxt.Text))
                        {
                            repeat_flag = false;
                            repeat_cnt = 0;
                        }
                        repeat_cnt++;
                        goto REPEAT;
                    }
                }

                information.Invoke((Action)delegate
                {
                    information.Text = "TALKING ROBOT";

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = true;

                }); image_type.Invoke((Action)delegate
                {
                    image_type.Visible = false;

                }); button5.Invoke((Action)delegate
                {
                    button5.Visible = true;

                }); button8.Invoke((Action)delegate
                {
                    button8.Visible = true;

                });
            }
            catch (Exception e)
            {
               // MessageBox.Show("" + e);
            }

        }

        private void animal_button_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            } pBuilder.ClearContent();
            if (user_name.Text.Length == 0 || user_name.Text == "enter your name")
            {
                user_name.Text = "enter your name";
                MessageBox.Show("ENTER YOUR NAME ", "NAME", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            username = user_name.Text;
            pBuilder.AppendText("LEARN  , ALPHA,BETS , a to  z  ," + username);
            synthesizer.SelectVoiceByHints(VoiceGender.Male);
            synthesizer.Speak(pBuilder);

            thread = new Thread(new ThreadStart(this.learn_abcd_animals));
            thread.Start();


        }
        public void learn_abcd_animals()
        {

            try
            {
                string image_path = null, image_tell = null;
                int i = 0;
                pBuilder.ClearContent();
                if (user_name.Text.Length == 0 || user_name.Text == "enter your name")
                {
                    user_name.Text = "enter your name";
                    MessageBox.Show("ENTER YOUR NAME ", "NAME", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                username = user_name.Text;
                pBuilder.AppendText("LEARN , ANIMALS , A to Z," + username);
                synthesizer.SelectVoiceByHints(VoiceGender.Male);
                synthesizer.Speak(pBuilder);


                // this.image_type = System.Windows.Forms.ImageLayout.Zoom;

                synthesizer.SelectVoiceByHints(VoiceGender.Female);
                information_number.Invoke((Action)delegate
                {
                    information_number.Visible = false;

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = false;

                });
                image_type.Invoke((Action)delegate
                {
                    image_type.Visible = true;

                });
                button5.Invoke((Action)delegate
                {
                    button5.Visible = false;

                });
                button8.Invoke((Action)delegate
                {
                    button8.Visible = false;

                });

                if (jump_flag == true)
                {
                    i = jump_to;
                    jump_flag = false;
                }


                for (i = 0; i <= 25; i++)
                {
                    if (jump_flag == true)
                    {
                        i = jump_to;
                        jump_flag = false;
                    }

                REPEAT:
                BACK: if (paus_play_status == true)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PLAY";
                            button7.Refresh();


                        });
                        goto BACK;

                    }
                    else if (paus_play_status == false)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PAUSE";
                            button7.Refresh();


                        });
                    }

                    pBuilder.ClearContent();

                    image_tell = db_animals.get_animals_description(i);
                    image_path = db_animals.get_animals_image_path(i);


                    information.Invoke((Action)delegate
                    {
                        information.Text = image_tell;
                    });
                    image_type.Invoke((Action)delegate
                    {
                        image_type.BackgroundImage = Image.FromFile(image_path);

                    });




                    pBuilder.AppendText(image_tell);
                    synthesizer.Speak(pBuilder);

                    if (repeat_flag == true)
                    {
                        if (repeat_cnt == int.Parse(repeat_texboxt.Text))
                        {
                            repeat_flag = false;
                            repeat_cnt = 0;
                        }
                        repeat_cnt++;
                        goto REPEAT;
                    }
                }


                information.Invoke((Action)delegate
                {
                    information.Text = "TALKING ROBOT";

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = true;

                }); image_type.Invoke((Action)delegate
                {
                    image_type.Visible = false;

                }); button5.Invoke((Action)delegate
                {
                    button5.Visible = true;

                }); button8.Invoke((Action)delegate
                {
                    button8.Visible = true;

                });
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (thread != null)
            {
                thread.Abort();
            } pBuilder.ClearContent();
            if (user_name.Text.Length == 0 || user_name.Text == "enter your name")
            {
                user_name.Text = "enter your name";
                MessageBox.Show("ENTER YOUR NAME ", "NAME", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            username = user_name.Text;
            pBuilder.AppendText("LEARN  ,numbers , 1 to 10 ," + username);
            synthesizer.SelectVoiceByHints(VoiceGender.Male);
            synthesizer.Speak(pBuilder);

            thread = new Thread(new ThreadStart(this.learn_1234));
            thread.Start();


        }
        public void learn_1234()
        {

            try
            {
                string image_path = null, image_tell = null;
                int i = 0;
                pBuilder.ClearContent();


                // this.image_type = System.Windows.Forms.ImageLayout.Zoom;

                synthesizer.SelectVoiceByHints(VoiceGender.Female);

                richTextBox1.Invoke((Action)delegate
                {
                    
                    richTextBox1.Visible = false;

                });
                image_type.Invoke((Action)delegate
                {
                    image_type.Visible = true;
                    image_type.BackgroundImage = null;

                });
                 information_number.Invoke((Action)delegate
                {
                    information_number.Visible = true;

                });
                button5.Invoke((Action)delegate
                {
                    button5.Visible = false;

                });
                button8.Invoke((Action)delegate
                {
                    button8.Visible = false;

                });




                for (i = 0; i <= 9; i++)
                {

                REPEAT:
                BACK: if (paus_play_status == true)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PLAY";
                            button7.Refresh();


                        });
                        goto BACK;

                    }
                    else if (paus_play_status == false)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PAUSE";
                            button7.Refresh();


                        });
                    }

                    pBuilder.ClearContent();

                    image_tell = db_number.get_number_description(i);
                    image_path = db_number.get_number_image_path(i);
                    information_number.Invoke((Action)delegate
                    {
                        information_number.Text = image_path;
                    });

                    information.Invoke((Action)delegate
                    {
                        information.Text = image_tell;
                    });
                   




                    pBuilder.AppendText(image_tell);
                    synthesizer.Speak(pBuilder);

                    if (repeat_flag == true)
                    {
                        if (repeat_cnt == int.Parse(repeat_texboxt.Text))
                        {
                            repeat_flag = false;
                            repeat_cnt = 0;
                        }
                        repeat_cnt++;
                        goto REPEAT;
                    }
                }


                information.Invoke((Action)delegate
                {
                    information.Text = "TALKING ROBOT";

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = true;

                }); image_type.Invoke((Action)delegate
                {
                    image_type.Visible = false;

                }); button5.Invoke((Action)delegate
                {
                    button5.Visible = true;

                }); button8.Invoke((Action)delegate
                {
                    button8.Visible = true;

                });
                information_number.Invoke((Action)delegate
                {
                    information_number.Visible =false;

                });
            }
            catch (Exception e)
            {
               // MessageBox.Show("" + e);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void date_time_Click(object sender, EventArgs e)
        {

        }

        private void random_button_Click(object sender, EventArgs e)
        {

            if (thread != null)
            {
                thread.Abort();
            } pBuilder.ClearContent();
            if (user_name.Text.Length == 0 || user_name.Text == "enter your name")
            {
                user_name.Text = "enter your name";
                MessageBox.Show("ENTER YOUR NAME ", "NAME", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            username = user_name.Text;
            pBuilder.AppendText("LEARN  , RANDOM , ALPHABHETS,  " + username);
            synthesizer.SelectVoiceByHints(VoiceGender.Male);
            synthesizer.Speak(pBuilder);

            thread = new Thread(new ThreadStart(this.learn_abcd_random));
            thread.Start();


        }

       
        public void learn_abcd_random()
        {

            try
            {
                string image_path = null, image_tell = null;
                int i = 0;
                pBuilder.ClearContent();


                // this.image_type = System.Windows.Forms.ImageLayout.Zoom;

                synthesizer.SelectVoiceByHints(VoiceGender.Female);
                information_number.Invoke((Action)delegate
                {
                    information_number.Visible = false;

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = false;

                });
                image_type.Invoke((Action)delegate
                {
                    image_type.Visible = true;

                });
                button5.Invoke((Action)delegate
                {
                    button5.Visible = false;

                });
                button8.Invoke((Action)delegate
                {
                    button8.Visible = false;

                });
                if (jump_flag == true)
                {
                    i = jump_to;
                    jump_flag = false;
                }



                for (i = 0; i <= 25; i++)
                {
                    if (jump_flag == true)
                    {
                        i = jump_to;
                        jump_flag = false;
                    }

                REPEAT:
                BACK: if (paus_play_status == true)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PLAY";
                            button7.Refresh();


                        });
                        goto BACK;

                    }
                    else if (paus_play_status == false)
                    {

                        button7.Invoke((Action)delegate
                        {
                            button7.Text = "PAUSE";
                            button7.Refresh();


                        });
                    }

                    pBuilder.ClearContent();
                    image_tell = db_fruits.get_fruit_description(i);
                    image_path = db_fruits.get_fruit_image_path(i);
                    information.Invoke((Action)delegate
                    {
                        information.Text = image_tell;
                    });
                    image_type.Invoke((Action)delegate
                    {
                        image_type.BackgroundImage = Image.FromFile(image_path);

                    });
                    pBuilder.AppendText(image_tell);
                    synthesizer.Speak(pBuilder);
                    pBuilder.ClearContent();

                    image_tell = db_animals.get_animals_description(i);
                    image_path = db_animals.get_animals_image_path(i);
                    information.Invoke((Action)delegate
                    {
                        information.Text = image_tell;
                    });
                    image_type.Invoke((Action)delegate
                    {
                        image_type.BackgroundImage = Image.FromFile(image_path);

                    });
                    pBuilder.AppendText(image_tell);
                    synthesizer.Speak(pBuilder);
                    pBuilder.ClearContent();
                    
                    image_tell = db_flags.get_flags_description(i);
                    image_path = db_flags.get_flags_image_path(i);
                    information.Invoke((Action)delegate
                    {
                        information.Text = image_tell;
                    });
                    image_type.Invoke((Action)delegate
                    {
                        image_type.BackgroundImage = Image.FromFile(image_path);

                    });

                    pBuilder.AppendText(image_tell);
                    synthesizer.Speak(pBuilder);

                    if (repeat_flag == true)
                    {
                        if (repeat_cnt == int.Parse(repeat_texboxt.Text))
                        {
                            repeat_flag = false;
                            repeat_cnt = 0;
                        }
                        repeat_cnt++;
                        goto REPEAT;
                    }
                }



                information.Invoke((Action)delegate
                {
                    information.Text = "TALKING ROBOT";

                });
                richTextBox1.Invoke((Action)delegate
                {
                    richTextBox1.Visible = true;

                }); image_type.Invoke((Action)delegate
                {
                    image_type.Visible = false;

                }); button5.Invoke((Action)delegate
                {
                    button5.Visible = true;

                }); button8.Invoke((Action)delegate
                {
                    button8.Visible = true;

                });
            }
            catch (Exception e)
            {
               // MessageBox.Show("" + e);
            }

        }

        private void jump_comboox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (jump_flag == false)
                {
                    jump_flag = true;
                }

                jump_to = jump_comboox.SelectedIndex;
            }
            catch(Exception ex)
            {

            }

           
        }



      
    }

}


