using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string TotalMiles { get; set; }
        public string LiscensePlate { get; set; }
        public bool CheckEngineLight { get; set; }
        public bool RecentOilChange { get; set; }
        public int VehicleNumber { get; set; }
        public bool HasSeatbelts { get; set; }
        public bool SpeedometerWorks { get; set; }
        public bool OdometerWorks { get; set; }
        public bool DoorsWork { get; set; }
        public bool HasAirbags { get; set; }
        public bool ShiftingProblems { get; set; }
        public bool BrakesWork { get; set; }
        public bool TiresNew { get; set; }
        public bool TiresFull { get; set; }
        public bool LightsWork { get; set; }
        public bool IsLoud { get; set; }
        public bool IdolsCorrectly { get; set; }
        public bool CanDrive { get; set; }
        public string Title { get; set; }
        public int Completion { get; set; }
        public bool NewBattery { get; set; }
        public bool Jumpstart { get; set; }
        public bool Overheat { get; set; }
        public bool DifficultBraking { get; set; }
        public bool DifficultTurning { get; set; }
        public bool LowEngineOil { get; set; }

        public Vehicle()
        {

        }

        public void SetVehicle(string Make, string Model, string Year, string TotalMiles, string LiscensePlate, bool CheckEngineLight, bool RecentOilChange, int VehicleNumber)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.TotalMiles = TotalMiles;
            this.LiscensePlate = LiscensePlate;
            this.CheckEngineLight = CheckEngineLight;
            this.RecentOilChange = RecentOilChange;
            this.VehicleNumber = VehicleNumber;
            SetTitle();
        }

        private void SetTitle()
        {
            Title = Make + " " + Model + " " + LiscensePlate;
        }

        public void SetInterior(bool HasSeatbelts, bool DoorsWork, bool SpeedometerWorks, bool OdometerWorks, bool HasAirbags, bool ShiftingProblems)
        {
            this.HasSeatbelts = HasSeatbelts;
            this.DoorsWork = DoorsWork;
            this.SpeedometerWorks = SpeedometerWorks;
            this.OdometerWorks = OdometerWorks;
            this.HasAirbags = HasAirbags;
            this.ShiftingProblems = ShiftingProblems;
        }
        
        public void SetExternals(bool BrakesWork, bool TiresNew, bool TiresFull, bool LightsWork, bool IsLoud, bool IdolsCorrectly)
        {
            this.BrakesWork = BrakesWork;
            this.TiresNew = TiresNew;
            this.TiresFull = TiresFull;
            this.LightsWork = LightsWork;
            this.IsLoud = IsLoud;
            this.IdolsCorrectly = IdolsCorrectly;
        }

        public void SetFluids(bool NewBattery, bool Jumpstart, bool Overheat, bool DifficultBraking, bool DifficultTurning, bool LowEngineOil)
        {
            this.NewBattery = NewBattery;
            this.Jumpstart = Jumpstart;
            this.Overheat = Overheat;
            this.DifficultBraking = DifficultBraking;
            this.DifficultTurning = DifficultTurning;
            this.LowEngineOil = LowEngineOil;
        }

        public void ApproveVehicle()
        {
            CanDrive = true;
        }

        public void DeclineVehicle()
        {
            CanDrive = false;
        }
    }
}
