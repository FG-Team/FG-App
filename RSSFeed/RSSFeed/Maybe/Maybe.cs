using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional
{
    public abstract class Maybe<A>
    {
        abstract public A FromJust();
        abstract public A FromMaybe(A defVal);
        virtual public bool IsJust() { return !(this.IsNothing()); }
        virtual public bool IsNothing() { return !(this.IsJust()); }
        abstract public B Apply<B>(B defVal, Func<A, B> fun);

        public static Maybe<B> Create<B>(B value)
        {
            if (value != null) return new Just<B>(value);
            else return Nothing<B>.Instance;
        }

        public static C[] MapMaybe<B,C>(Func<B,Maybe<C>> fun, B[] iterable)
        {
            var results = new List<C>();
            foreach (var value in iterable)
            {
                var applied = fun(value);
                if (applied.IsJust()) results.Add(applied.FromJust());
            }
            return results.ToArray();
        }

        abstract public Maybe<B> Fmap<B>(Func<A, B> fun);
        
        virtual public Maybe<B> Bind<B>(Func<A, Maybe<B>> fun) { 
            return fun(this.FromJust()); 
        }


    }
}
