// ReSharper disable once CheckNamespace

namespace System;

public static class FunctionalExtensions
{
    public static TResult Map<TSource, TResult>(this TSource @this, Func<TSource, TResult> fn) => fn(@this);

    public static T Tie<T>(this T @this, Action<T> act)
    {
        act(@this);
        return @this;
    }

    public static async Task<T> Tie<T>(this T @this, Func<T, Task> act)
    {
        await act(@this);
        return @this;
    }
}
