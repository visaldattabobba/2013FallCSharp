using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample1
{
    public class Vehicle
    {
        #region "Properties".
        public string Log { get; set; }
        public Action<string> BreakDown { get; set; }
        #endregion

        #region "Constant"
        public const int SPEED = 10;
        #endregion

        #region "Interface"
        public IEnumerable<string> Seats = new List<string> { "Driver", "Shotgun", "Rear", "Backseat driver" };
        #endregion

        #region "Constructor"
        public Vehicle()
        {
        //    BreakDown  = delegate  {
        //    Log += "/nWe Broke Down.";
        //};
            BreakDown = x => Log += "/nWe Broke Down.";

        }
#endregion


        public virtual void Drive()
        {
            Log += "\nWe Drove Somewhere.";
        }

        public void Crash(Func<int,int> impact)
        {
            foreach (var seat in Seats)
            {
                Log += seat + " affected ";
            }
            Log += "This is: " + string.Join(",", Seats);

            Log += "/r/nThe impact was: " + impact(SPEED);
        }
       
    }

    public class Car : Vehicle
    {
        public void Park()
        {
            Drive();
            // Get into parked state
            /*
             * THis is another comment
             */

        }
    }

    public class Plane : Vehicle
    {
        #region "Constructor"
        public Plane()
        {
            //BreakDown = delegate
            //{
            //    Log += "/nWe Fell Down.";
            //};
            BreakDown = x => Log += "/nWe Fell Down.";
        }
        #endregion
        public override void Drive()
        {
            //base.Drive();
            Log += "/nWe Flew Somewhere.";
        }
    }

    public static class Extensions
    {
        public static void Transform(Vehicle v)
        {
            v.Log += " I am now a AutoBot.";
        }

        public static void TransformVehicle(this Vehicle v)
        {
            v.Log += " I am now a AutoBot.";
        }
    }
}
