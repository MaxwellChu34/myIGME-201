using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_UT2_Number9to10
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Answers Numbers 9 and 10 based off Number 8
     * Restrictions: None
     */
    internal class Program
    {
        /* Method: Main
         * Purpose: Creates a C# console application based off a custom schUML that demonstrates polymorphism
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            BigDog baobao = new BigDog();
            SmallDog quinquin = new SmallDog();
            MyMethod(baobao);
            MyMethod(quinquin);
        }
        static void MyMethod(object obj)
        {
            Type type = obj.GetType();
            if (type == typeof(BigDog))
            {
                BigDog baobao = (BigDog)obj;
                baobao.Restrain();
            } else if (type == typeof(SmallDog))
            {
                SmallDog quinquin = (SmallDog)obj;
                quinquin.BagTransport();
            }
            WalkingDog walk = (WalkingDog)obj;
            walk.WaterBreak();
        }
    }
    public abstract class WalkingDog
    {
        public bool PickupPoop { get; set; }
        public abstract bool WaterBreak();
    }
    public interface IBigDog
    {
        void Restrain();
    }
    public interface ISmallDog
    {
        void BagTransport();
    }
    public class BigDog : WalkingDog, IBigDog
    {
        public virtual void Restrain()
        {

        }
        public override bool WaterBreak()
        {
            return true;
        }
    }
    public class SmallDog : WalkingDog, ISmallDog
    {
        public virtual void BagTransport()
        {

        }
        public override bool WaterBreak()
        {
            return true;
        }
    }
}