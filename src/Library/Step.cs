//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
       
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        
         //Step se encarga de calcular el costo de cada paso por patron Expert puesto que tiene toda la informacion de los mismos.
        public double StepCost
        {
            get
            {
                return (this.Quantity * this.Input.UnitCost) + (this.Equipment.HourlyCost * this.Time);
            }
        }
    }
}