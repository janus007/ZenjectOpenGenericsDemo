using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    class OnParticleCollisionFooImplementation : ICollision<Foo>
    {
        public string Process(Foo t)
        {
            return t.Payload() + "FooCollisionVisitorImplementation";
        }
    }
    class OnParticleCollisionBarImplementation : ICollision<Bar>
    {
        public string Process(Bar t)
        {
            return t.Payload() + "BarCollisionVisitorImplementation";
        }
    }
    class OnParticleCollisionFoo:Collision<Foo>
    {
        public override string Process(Foo t)
        {
            return t.Payload() + "FooCollisionVisitor";
        }
    }

    class OnParticleCollisionBar : Collision<Bar>
    {
        public override string Process(Bar t)
        {
            return t.Payload() + "BarCollisionVisitor";
        }
    }

    public interface ILoadedWith
    {
        string Payload();
    }

    class Bar:ILoadedWith
    {
        public string Payload()
        {
            return "Ouch";
        }
    }

    class Foo:ILoadedWith
    {
        public string Payload()
        {
            return "Ouch";
        }
    }
}
