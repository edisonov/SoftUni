using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<Computer> computers;
        private List<Component> components;
        private List<Peripheral> peripherals;

        public Controller()
        {
            computers = new List<Computer>();
            components = new List<Component>();
            peripherals = new List<Peripheral>();
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            Computer computer = null;

            switch (computerType)
            {
                case "DesktopComputer":
                    computer = new DesktopComputer(id, manufacturer, model, price);
                    break;
                case "Laptop":
                    computer = new Laptop(id, manufacturer, model, price);
                    break;
                default:
                    throw new ArgumentException("");
            }

            foreach (var comp in computers)
            {
                if (comp.Id == computer.Id)
                {
                    throw new ArgumentException("");
                }
            }

            computers.Add(computer);
            return string.Format(SuccessMessages.AddedComputer, id);
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price,
            double overallPerformance, string connectionType)
        {
            Peripheral peripheral;

            switch (peripheralType)
            {
                case "Headset":
                    peripheral = new Headset(id, manufacturer, model, price,
                        overallPerformance, connectionType);
                    break;
                case "Keyboard":
                    peripheral = new Keyboard(id, manufacturer, model, price,
                        overallPerformance, connectionType);
                    break;
                case "Monitor":
                    peripheral = new Monitor(id, manufacturer, model, price,
                        overallPerformance, connectionType);
                    break;
                case "Mouse":
                    peripheral = new Mouse(id, manufacturer, model, price,
                        overallPerformance, connectionType);
                    break;
                default:
                    throw new ArgumentException("");
                break;
            }

            foreach (var item in peripherals)
            {
                if (item.Id == peripheral.Id)
                {
                    throw new ArgumentException("");
                }
            }

            computers.FirstOrDefault(e => e.Id == computerId).AddPeripheral(peripheral);
            peripherals.Add(peripheral);

            return String.Format(SuccessMessages.AddedPeripheral, id, computerId);
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            Peripheral peripheral = peripherals
                .FirstOrDefault(x => x.GetType().Name == peripheralType);

            peripherals.Remove(peripheral);

            foreach (var comp in computers)
            {
                if (comp.Id == computerId)
                {
                    comp.RemovePeripheral(peripheralType);
                }
            }

            return string.Format(SuccessMessages.RemovedPeripheral, peripheralType, peripheral.Id);
        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
        {
            Component component;
            switch (componentType)
            {
                case "CentralProcessingUnit":
                    component = new CentralProcessingUnit(id, manufacturer, model, 
                        price, overallPerformance, generation);
                    break;
                case "Motherboard":
                    component = new Motherboard(id, manufacturer, model,
                        price, overallPerformance, generation);
                    break;
                case "PowerSupply":
                    component = new PowerSupply(id, manufacturer, model,
                        price, overallPerformance, generation);
                    break;
                case "RandomAccessMemory":
                    component = new RandomAccessMemory(id, manufacturer, model,
                        price, overallPerformance, generation);
                    break;
                case "SolidStateDrive":
                    component = new SolidStateDrive(id, manufacturer, model,
                        price, overallPerformance, generation);
                    break;
                case "VideoCard":
                    component = new VideoCard(id, manufacturer, model,
                        price, overallPerformance, generation);
                    break;
                default:
                    throw new ArgumentException("");
            }

            foreach (var comp in components)
            {
                if (comp.Id == computerId)
                {
                    throw new ArgumentException("");
                }
            }

            computers.FirstOrDefault(x=>x.Id == computerId).AddComponent(component);

            components.Add(component);

            return string.Format(SuccessMessages.AddedComponent, componentType, id, computerId);
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            Component component = components
                .FirstOrDefault(x => x.GetType().Name == componentType);

            components.Remove(component);

            foreach (var comp in computers)
            {
                if (comp.Id == computerId)
                {
                    comp.RemoveComponent(componentType);
                }
            }

            return string.Format(SuccessMessages.RemovedComponent, componentType, component.Id);
        }

        public string BuyComputer(int id)
        {
            Computer computer = computers.FirstOrDefault(x => x.Id == id);

            if (computer == null)
            {
                throw new ArgumentException("");
            }

            computers.Remove(computer);
            return computer.ToString();
        }

        public string BuyBest(decimal budget)
        {
            double maxPreformes = components.Max(x => x.OverallPerformance);
            Computer computer = computers
                .FirstOrDefault(x => x.OverallPerformance == maxPreformes);

            if (computer == null || budget <computer.Price)
            {
                throw new ArgumentException("");
            }

            computers.Remove(computer);
            return computer.ToString();
        }

        public string GetComputerData(int id)
        {
            Computer computer = computers.FirstOrDefault(x => x.Id == id);

            if (computer == null)
            {
                throw new ArgumentException("");
            }

            return computer.ToString();
        }
    }
}