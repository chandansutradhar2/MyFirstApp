using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{

    public class Car {

        public string carName;
        public string carId;
        public string carType;
        public MFG_NAME mfgName;
        public string modelNo;
        public string modelType;
        
        public int engineCapacity;

        public Car( string _name,MFG_NAME _mfgName, string _modelNo) {
            this.carName = _name;
            this.mfgName = _mfgName;
            this.modelNo = _modelNo;

            if (this.mfgName == MFG_NAME.TATA) { 
            //code to give discount
            }
        }

        public Car(string _name)
        {
            this.carName= _name;

        }
        public void Start() {
            Console.WriteLine($"{this.carName} Car started..");
        }

        //method declaration
        public void Stop() {
            Console.WriteLine("Car Stopped..");
            //try
            //{

            //}
            //catch (Exception exe)
            //{
            //}
        }

 
         public void Accelerate()
        {
            Console.WriteLine("Car Accelerated..");

        }


        public void Break() {
            Console.WriteLine("Car Breaked..");
        }
    }

    //public class RaceCar:Car {

    //    public void BoostNitro(int speedBoost) {
    //        Console.WriteLine($"boosting car speed to {speedBoost * 10 } X Speed ");
    //    }

    //}


    public enum MFG_NAME { 
    TATA,
    HYUNDAI,
    TOYOTA,
    HONDA,
    KIA,
    MAHINDRA,
    MARUTI
    }
}
