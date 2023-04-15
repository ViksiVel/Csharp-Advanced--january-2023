using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiprocessor;
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            multiprocessor = new List<CPU>();
        }

        public string Model  { get; set; }
        public int Capacity  { get; set; }
        public List<CPU> Multiprocessor => multiprocessor;


        public int Count
        {
            get { return Multiprocessor.Count; }
        }

        public void Add(CPU cpu)
        {
            if (Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            
                var cpuToRemove = Multiprocessor.FirstOrDefault(x => x.Brand == brand);

                if (cpuToRemove != default)
                {
                    Multiprocessor.Remove(cpuToRemove);
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        public CPU MostPowerful() => Multiprocessor.OrderByDescending(x => x.Frequency).FirstOrDefault();

        public CPU GetCPU(string brand) => Multiprocessor.FirstOrDefault(x => x.Brand == brand);

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var cpu in Multiprocessor)
            {
                sb.AppendLine(cpu.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
