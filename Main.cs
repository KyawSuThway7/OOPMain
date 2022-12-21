using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentforOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account();
                account.SetName("Kyaw su");
                account.SetEamil1("Kyawsuthway.mtal2001@gmail.com");
                account.SetAddress(" Meiktila");
                account.showinfo();
                Console.WriteLine();
                Admin admin = new Admin();
                admin.CreatePost();
                admin.Years=1;
                admin.minutes = 10;
                double YougetMoney = admin.GetMoneyFromUser(10,3,5);//If you Get 10kyats from user ,you tax 5 kyats to AppCreater
                admin.YouGetMoney(admin.minutes, YougetMoney);//If user watch one minute , you get 10 kyats.
                double totalphoto =admin.ChangeCoverphoto(admin.Years);
                admin.ChangeCoverPhotoInYear(admin.Years,totalphoto);
                Console.WriteLine();
                Viewer viewer = new Viewer();
                viewer.YourReaction();
                viewer.minutes = 10;
                double YourPaymnet = viewer.Yourpaymaent(viewer.minutes);
                viewer.YourpaymentwithMinutes(viewer.minutes, YourPaymnet);
                double Oscar = viewer.WatchOscarvideo(2);
                Console.WriteLine($"If You  watch Oscar video ,you pay {Oscar} kyats");
                double other = viewer.WatchFunnyvideo(2);
                Console.WriteLine($"If You  watch other video ,you pay {other} kyats");
                double post = viewer.WatchPost(2);
                Console.WriteLine($"If You  watch post ,you pay {post} kyats");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Error1!");
            }
            catch(Exception e1)
            {
                Console.WriteLine("Name and Email have some error! Please Check Out");
            }

           

            Console.WriteLine("Press any key to the window");
            Console.ReadKey();
        }
    }
}
