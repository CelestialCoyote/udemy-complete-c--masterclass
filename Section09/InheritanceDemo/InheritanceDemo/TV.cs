using System;


namespace InheritanceDemo
{
    public class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
     
        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching the TV");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
