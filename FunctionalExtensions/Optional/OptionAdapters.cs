/*
 * This class is created based on Zoran Horvat's trainings. For details please see: https://codinghelmet.com/
 */

// ReSharper disable once CheckNamespace
namespace System;

public static class OptionAdapters
{
    public static Option<T> AsOption<T>(this T? @this) where T : class => @this;
    public static Option<T> AsOption<T>(this T? @this) where T : struct => Option<T>.From(@this);
}
