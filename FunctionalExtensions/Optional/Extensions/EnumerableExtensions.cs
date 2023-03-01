/*
 * This class is created based on Zoran Horvat's trainings. For details please see: https://codinghelmet.com/
 */

// ReSharper disable once CheckNamespace
namespace System;

public static class EnumerableExtensions
{
    public static IEnumerable<Option<T>> AsOptional<T>(this IEnumerable<T> sequence) =>
        sequence
            .Select(x => (Option<T>) x)
            .DefaultIfEmpty(new None<T>());

    public static Option<T> FirstOrNone<T>(this IEnumerable<T> sequence) =>
        sequence.AsOptional().First();

    public static Option<T> LastOrNone<T>(this IEnumerable<T> sequence) =>
        sequence.AsOptional().Last();

    public static Option<T> FirstOrNone<T>(this IEnumerable<T> sequence, Func<T, bool> predicate) =>
        sequence.Where(predicate).FirstOrNone();

    public static Option<T> LastOrNone<T>(this IEnumerable<T> sequence, Func<T, bool> predicate) =>
        sequence.Where(predicate).LastOrNone();

    public static Option<T> SingleOrNone<T>(this IEnumerable<T> sequence) =>
        sequence.AsOptional().Single();

    public static Option<T> SingleOrNone<T>(this IEnumerable<T> sequence, Func<T, bool> predicate) =>
        sequence.Where(predicate).SingleOrNone();

    public static IEnumerable<TResult> SelectOptional<T, TResult>(
        this IEnumerable<T> sequence, Func<T, Option<TResult>> map) =>
        sequence.Select(map)
            .OfType<Some<TResult>>()
            .Select(some => some.Content);
}
