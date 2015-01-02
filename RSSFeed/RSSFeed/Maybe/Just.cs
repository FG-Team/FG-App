using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional
{
    public class Just<A> : Maybe<A>
    {
        private A value;

        public Just(A value)
        {
            this.value = value;
        }

        override public A FromJust()
        {
            return this.value;
        }

        override public A FromMaybe(A defVal)
        {
            return this.value;
        }

        override public bool IsJust()
        {
            return true;
        }

        public override string ToString()
        {
            return "Just " + this.value.ToString();
        }

        public override Maybe<B> Fmap<B>(Func<A,B> fun)
        {
            return new Just<B>(fun(this.FromJust()));
        }

        public override B Apply<B>(B defVal, Func<A, B> fun)
        {
            return fun(this.FromJust());
        }

        public override Maybe<B> Bind<B>(Func<A,Maybe<B>> fun)
        {
            return fun(this.value);
        }

    }
}
