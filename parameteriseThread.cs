  private void button1_Click(object sender, EventArgs e)
        {
            int kk = 10;
            // myDelegate d = new myDelegate(helloworld);


            //int A = 1;
            //string B = "Test";
            //Thread ActionThread = new Thread(new ParameterizedThreadStart(helloworld));
            //ActionThread.SetApartmentState(ApartmentState.MTA);
            //ActionThread.Priority = ThreadPriority.Highest;
            //ActionThread.Start(new { A, B });

            int A = 1;
            string B = "Test";
            threadServer = new Thread(new  ParameterizedThreadStart(helloworld));
            threadServer.SetApartmentState(ApartmentState.MTA);
            threadServer.Priority = ThreadPriority.Highest;
            xmlData xmldata = new xmlData(10,20,30,40);
            
            threadServer.Start(xmldata);
            
            // d.Invoke(kk);


            // t.SetApartmentState(ApartmentState.STA);

            //Method1();
            //var backgroundTasks = new[] {Task.Run(() => helloworld(1)) };

        }
        private static void helloworld(object parameters)
        {
            dynamic d = parameters;

            xmlData x  = d;
            
            while (true)
            {
                Console.WriteLine(" Method 1 p1 = {0} p2 = {1} p3 = {2}  p4 = {3}" ,x.p1,x.p2,x.p3,x.p4);
                Thread.Sleep(1000);
                // Do something
               // Task.Delay(100).Wait();
            }

        }
