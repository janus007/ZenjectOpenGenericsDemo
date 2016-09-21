using UnityEngine;
using System.Collections;
using Zenject;
using UnityEngine.Assertions;

public class TestInstaller : MonoInstaller {

    public override void InstallBindings()
    {

        Container.Bind(typeof(Assets.ICollision<>));
        var shouldBeBarImpl = Container.Resolve<Assets.ICollision<Assets.Bar>>();
        var shouldBeFooImpl = Container.Resolve<Assets.ICollision<Assets.Foo>>();

        Container.Bind(typeof(Assets.Collision<>));

        var shouldBeBar = Container.Resolve<Assets.Collision<Assets.Bar>>();
        var shouldBeFoo = Container.Resolve<Assets.Collision<Assets.Foo>>();

        
        var stringBar =  shouldBeBar.Process(new Assets.Bar());
        var stringFoo = shouldBeFoo.Process(new Assets.Foo());

        Assert.IsTrue("OuchBarCollisionVisitor" == stringBar);
        Assert.IsTrue("OuchFooCollisionVisitor" == stringFoo);

    }
}
