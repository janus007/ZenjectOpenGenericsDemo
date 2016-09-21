using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public abstract class Collision<T> //where T: ILoadedWith <-- not valid in Unity3D :(
    {
        public abstract string Process(T t);
    }

    public interface ICollision<T>
    {
        string Process(T t);
    }
}
