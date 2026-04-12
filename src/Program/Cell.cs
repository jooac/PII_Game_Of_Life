using System;

namespace Program
{
/// <summary>
/// Esta clase representa una célula del tablero.
/// Cumple con SRP porque su única responsabilidad es tener un estado viva/muerta,
/// representada en booleano, por lo que solo tiene una razón de cambio.
/// También cumple con Expert, porque ninguna clase mejor que la propia celula,
/// para conocer y cambiar su estado.
/// </summary>
    public class Cell
    {
        private bool state;
        public bool State
        {
            get {return state;}
            set {state = value;}
        }
        // Método de la propia célula que invierte el estado de la misma,
        // si estaba viva, pasa a estar muerta y viceversa.
        public void ChangeState()
        {
            if (State == true)
            {
                State = false;
            } else
            {
                State = true;
            }
        }
    }
}