using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; private set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public Airfield (string name, int capacity, double landStrip )
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landStrip;
            this.Drones = new List<Drone> ();
        }

        public int Count => this.Drones.Count;

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name)||
                string.IsNullOrEmpty(drone.Brand) ||
                drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            if (Drones.Count >= this.Capacity )
            {
                return "Airfield is full.";
            }
            
                this.Drones.Add (drone);
                return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            int count = this.Drones.RemoveAll(dr => dr.Name == name);
            return count > 0;
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = this.Drones.RemoveAll(dr => dr.Brand == brand);
            return count;
        }

        public Drone FlyDrone(string name)
        {
            Drone drone = this.Drones.FirstOrDefault(d => d.Name == name);
            if (drone == null)
            {
                return null;
                drone.Available = false;
            }

            return drone; 
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = this.Drones.FAll(d => d.Range == range);
            if (drone == null)
            {
                return null;
                drone.Available = false;
            }

            return drone;
        }
    }

    
}
 