using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace VehicleLibrary
{
    public class Car
    {
        public Engine engine = new Engine();
        public FuelSystem fuelSystem = new FuelSystem();
        public ExhaustSystem exhaustSystem = new ExhaustSystem();
        public CoolingSystem coolingSystem = new CoolingSystem();
        public LubricationSystem lubricationSystem = new LubricationSystem();
        public ElectricalSystem electricalSystem = new ElectricalSystem();
        public Transmission transmission = new Transmission();
        public Chassis chassis = new Chassis();

        public Car()
        {
            ;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public double TotalMiles { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleIdentificationNumber { get; set; }

        public void SerializeObject(string filename)
        {
            XmlSerializer serializer =
            new XmlSerializer(typeof(Car));
            Stream fs = new FileStream(filename, FileMode.Create);
            XmlWriter writer = new XmlTextWriter(fs, Encoding.Unicode);
            serializer.Serialize(writer, this);
            writer.Close();
        }
        public void setEngine(int cylinders, double horsepower, double oil)
        {
            // 4 quarts oil
            engine.cylinders = cylinders;
            engine.horsepower = horsepower;
            engine.oil = oil;
        }
        public void setFuelSystem(double gasoline)
        {
            // 15 gallons of gas
            fuelSystem.gasoline = 15;
        }
        public void setCoolingSystem(double coolant)
        {
            coolingSystem.coolant_level = coolant;
        }
        public void setTransmission(double transmissionFluid)
        {
            transmission.transmission_fluid = transmissionFluid;
        }
    }
    public class Engine
    {
        bool isOK = true;
        public int cylinders { get; set; }
        public double horsepower { get; set; }
        public double oil { get; set; }
        public int check()
        {
            if (oil < 2)
            {
                isOK = false;
            }
            if (isOK)
                return 0;
            else
                return 1;
        }
    }

    public class FuelSystem
    {    
        public double gasoline { get; set; }
        bool isOK = true;
        public int check ()
        {
            if (gasoline < 0.5)
            {
                isOK = false;
            }

            if (isOK)
                return 0;
            else
                return 1;
        }

    }
    public class ExhaustSystem
    {
        bool isOK = true;
        public int check()
        {
            if (isOK)
                return 0;
            else
                return 1;
        }
    }
    public class CoolingSystem
    {
        public double coolant_level { get; set; }
        bool isOK = true;
        public int check()
        {
            if (isOK)
                return 0;
            else
                return 1;
        }
    }
    public class LubricationSystem
    {
        bool isOK = true;
        public int check()
        {
            if (isOK)
                return 0;
            else
                return 1;
        }

    }
    public class ElectricalSystem
    {
        Battery battery = new Battery(120);
        public void setAmps (double amps)
        {
            battery.amps = amps;
        }
        bool isOK = true;
        public int check()
        {
            if (isOK)
                return 0;
            else
                return 1;
        }
    }

    public class Transmission
    {
        public double transmission_fluid { get; set; }
        bool isOK = true;
        public int check()
        {
            if (isOK)
                return 0;
            else
                return 1;
        }

    }
    public class Chassis
    {
        public double power_steering_fluid { get; set; }
        
        Tire lf = new Tire();      
        Tire rf = new Tire();
        Tire lr = new Tire();
        Tire rr = new Tire();
        Brakes brakes = new Brakes();
        SuspensionSystem suspensionSystem = new SuspensionSystem();
        Body body = new Body();
        bool isOK = true;
        public int check()
        {
            if (isOK)
                return 0;
            else
                return 1;
        }
    }
    public class Battery
    {
        public Battery(double amps)
        {
            this.amps = amps;
        }
        public double amps { get; set; }
    }
    public class Tire
    {
        public double pressure { get; set; }
        public int wear { get; set; }

    }
    class Brakes
    {
        public string type { get; set; }
        public double brake_fluid { get; set; }
        public int wear { get; set; }
    }
    class SuspensionSystem
    {

    }
    class Body
    {

    }
}
