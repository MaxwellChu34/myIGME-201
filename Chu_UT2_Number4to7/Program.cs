using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_UT2_Number4to7
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Contains the answer for numbers 4, 5, 6, and 7 on the Unit 2 Test
     * Restrictions: None
     */
    internal class Program
    {
        /* Method: Main
         * Purpose: Creates new objects of tardis and phonebooth, and then sends them to the UsePhone method
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phonebooth = new PhoneBooth();
            UsePhone(tardis);
            UsePhone(phonebooth);
        }
        static void UsePhone(object obj)
        {
            Type type = obj.GetType();
            if (type == typeof(Tardis))
            {
                Tardis tardis = (Tardis)obj;
                tardis.TimeTravel();
            } else if (type == typeof(PhoneBooth))
            {
                PhoneBooth phonebooth = (PhoneBooth)obj;
                phonebooth.OpenDoor();
            }
            PhoneInterface call = (PhoneInterface)obj;
            call.MakeCall();
            call.HangUp();
        }
    }
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public abstract void Connect();
        public abstract void Disconnect();
    }
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }
    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }
        public void HangUp()
        {

        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }
    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }
        public void HangUp()
        {

        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;
        public byte WhichDrWho { get { return whichDrWho; } }
        public string FemaleSideKick { get { return femaleSideKick; } }
        public void TimeTravel()
        {

        }
        public static bool operator ==(Tardis One, Tardis Two)
        {
            return One.whichDrWho == Two.whichDrWho;
        }
        public static bool operator !=(Tardis One, Tardis Two)
        {
            return One.whichDrWho != Two.whichDrWho;
        }
        public static bool operator <(Tardis One, Tardis Two)
        {
            if (One.whichDrWho == 10)
            {
                return false;
            }
            if (Two.whichDrWho == 10)
            {
                return true;
            }
            return One.whichDrWho < Two.whichDrWho;
        }
        public static bool operator >(Tardis One, Tardis Two)
        {
            if (One.whichDrWho == 10)
            {
                return true;
            }
            if (Two.whichDrWho == 10)
            {
                return false;
            }
            return One.whichDrWho > Two.whichDrWho;
        }
        public static bool operator <=(Tardis One, Tardis Two)
        {
            if (One.whichDrWho == 10)
            {
                if (Two.whichDrWho == 10)
                {
                    return true;
                }
                return false;
            }
            if (Two.whichDrWho == 10)
            {
                if (One.whichDrWho == 10)
                {
                    return false;
                }
                return true;
            }
            return One.whichDrWho <= Two.whichDrWho;
        }
        public static bool operator >=(Tardis One, Tardis Two)
        {
            if (Two.whichDrWho == 10)
            {
                if (One.whichDrWho == 10)
                {
                    return true;
                }
                return false;
            }
            if (One.whichDrWho == 10)
            {
                if (Two.whichDrWho == 10)
                {
                    return false;
                }
                return true;
            }
            return One.whichDrWho >= Two.whichDrWho;
        }
    }
    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;
        public void OpenDoor()
        {

        }
        public void CloseDoor()
        {

        }
    }
}