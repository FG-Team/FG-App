using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional
{
    public class Nothing<A> : Maybe<A>
    {
        private static Nothing<A> instance;

        private Nothing() {}

        public override A FromJust()
        {
            throw new NotImplementedException();
        }

        public static Nothing<A> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Nothing<A>();
                }
                return instance;
            }
        }

        override public A FromMaybe(A defVal)
        {
            return defVal;
        }

        override public bool IsNothing()
        {
            return true;
        }

        override public Maybe<B> Fmap<B>(Func<A,B> fun)
        {
            return new Nothing<B>();
        }

        public override string ToString()
        {
            return "Nothing";
        }

        override public B Apply<B>(B defVal, Func<A, B> fun)
        {
            return defVal;
        }

        override public Maybe<B> Bind<B>(Func<A,Maybe<B>> fun)
        {
            return new Nothing<B>();
        }
    }
}
