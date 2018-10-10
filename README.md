# G42.TimeProvider

## What it it?
A way to abstract time that allows for time travel in your unit tests.

## Why?
Writing `DateTime.UtcNow` ties your code to "right now" which causes temporal issues in unit testing. This simple package allows you to swap out how time is configured in your entire app.

For instance you can:
1) Use `DateTime.UtcNow` in production
2) Use `SpecificTimeProvider` to set the current date to an exact date\time in tests.
3) Use `SpecificTimeProvider` to advance time to a specific date\time after a step has occurred in tests.

## Usage
Each provider implements `ITimeProvider`.

To new one up, simply new things up and call `GetTime()`.

```
var provider = new SystemUtcDateTimeProvider();
var rightNow = provider.GetTime();//whatever the UTC time right now
```

```
var provider = new SpecificTimeProvider(new DateTime(1955, 11, 5);
var rightNow = provider.GetTime();//will always be November 5, 1955
provider.SetTime(new DateTime(1985, 10, 26));//travel to Oct 26th, 1985
rightNow = provider.GetTime();//Great Scott!
```

## Dependency Injection
```
var container = new UnityContainer();//obviously using Unity here
container.RegisterType<ITimeProvider, SystemUtcTimeProvider>();
OR
container.RegisterType<ITimeProvider, SpecificTimeProvider>(new SingletonLifetimeManager(), new InjectionConstructor(specificTime));
```

## Notes
Make sure you never call `DateTime.<whatever>` in your code by depending on `ITimeProvider`.

In this way you can change then entire app's clock by simply using whatever time provider you choose.
