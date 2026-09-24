using System;
using System.Collections.Generic;

namespace TorreHanoi
{
    public class HanoiTower
    {
        public int DiscsCount { get; private set; }

        public int MovesCount { get; private set; }

        public Stack<int> From { get; private set; }

        public Stack<int> To { get; private set; }

        public Stack<int> Auxiliary { get; private set; }

        public event EventHandler<EventArgs> MoveCompleted;

        public HanoiTower(int discs)
        {
            DiscsCount = discs;

            From = new Stack<int>();
            To = new Stack<int>();
            Auxiliary = new Stack<int>();

            // Coloca os discos na pilha inicial
            for (int i = discs; i >= 1; i--)
            {
                From.Push(i);
            }
        }

        public void Start()
        {
            Move(
                DiscsCount,
                From,
                To,
                Auxiliary
            );
        }

        public void Move(
            int discs,
            Stack<int> from,
            Stack<int> to,
            Stack<int> auxiliary)
        {
            if (discs > 0)
            {
                // 1. Move n-1 para a auxiliar
                Move(
                    discs - 1,
                    from,
                    auxiliary,
                    to
                );

                // 2. Move o maior disco para o destino
                to.Push(from.Pop());

                MovesCount++;

                MoveCompleted?.Invoke(
                    this,
                    EventArgs.Empty
                );

                // 3. Move n-1 da auxiliar para o destino
                Move(
                    discs - 1,
                    auxiliary,
                    to,
                    from
                );
            }
        }
    }
}
