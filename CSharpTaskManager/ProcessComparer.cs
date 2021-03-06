﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CSharpTaskManager
{
   
    public class ProcessComparer<Component> : IEqualityComparer<Component>
    {
        public ComparisonType ComparisonProperty { set; get; } = ComparisonType.NA;
        public bool Equals(Component x, Component y)
        {
            if (x == null || y == null)
            {
                if (x == null)
                    throw new Exception($"x was null in Process Comparer y is {y}");
                else
                    throw new Exception($"y was null in Process Comparer x is {x}");
            }
            
            if (ComparisonProperty == ComparisonType.PID)
            {

                if (x.GetType() == typeof(Process) && y.GetType() == typeof(Process))
                    return (x as Process).Id == (y as Process).Id;
                else if (x.GetType() == typeof(ProcessObject) && y.GetType() == typeof(ProcessObject))
                    return (x as ProcessObject).Id == (y as ProcessObject).Id;
                else if (x.GetType() == typeof(ProcessObject) && y.GetType() == typeof(Process))
                    return (x as ProcessObject).Id == (y as Process).Id;
                else
                    return (x as Process).Id == (y as ProcessObject).Id;
            }
            else if (ComparisonProperty == ComparisonType.NAME)
            {

                if (x.GetType() == typeof(Process) && y.GetType() == typeof(Process))
                    return String.Equals((x as Process).ProcessName, (y as Process).ProcessName, StringComparison.OrdinalIgnoreCase);
                else if (x.GetType() == typeof(ProcessObject) && y.GetType() == typeof(ProcessObject))
                    return String.Equals((x as ProcessObject).ProcessName, (y as ProcessObject).ProcessName, StringComparison.OrdinalIgnoreCase);
                else if (x.GetType() == typeof(ProcessObject) && y.GetType() == typeof(Process))    
                    return String.Equals((x as ProcessObject).ProcessName, (y as Process).ProcessName, StringComparison.OrdinalIgnoreCase);
                else 
                    return String.Equals((x as Process).ProcessName, (y as ProcessObject).ProcessName, StringComparison.OrdinalIgnoreCase);
                
            }
            else if (ComparisonProperty == ComparisonType.FULL)
            {
                if (x.GetType() == typeof(Process) && y.GetType() == typeof(Process))
                    return (x as Process).Id == (y as Process).Id && (x as Process).ProcessName == (y as Process).ProcessName;
                else if (x.GetType() == typeof(ProcessObject) && y.GetType() == typeof(ProcessObject))
                    return (x as ProcessObject).Id == (y as ProcessObject).Id && (x as ProcessObject).ProcessName == (y as ProcessObject).ProcessName;
                else if (x.GetType() == typeof(ProcessObject) && y.GetType() == typeof(Process))
                    return (x as ProcessObject).Id == (y as Process).Id && (x as ProcessObject).ProcessName == (y as Process).ProcessName;
                else
                    return (x as Process).Id == (y as ProcessObject).Id && (x as Process).ProcessName == (y as ProcessObject).ProcessName;
            }
            else
                throw new Exception("Comparison type not specified. " + ComparisonProperty);

        }

        public int GetHashCode(Component obj)
        {
            if (ComparisonProperty == ComparisonType.NAME)
            {
                if (obj.GetType() == typeof(Process))
                    return (obj as Process).ProcessName.GetHashCode();
                else
                    return (obj as ProcessObject).ProcessName.GetHashCode();
            }
            else if (ComparisonProperty == ComparisonType.PID)
            {
                if (obj.GetType() == typeof(Process))
                    return (obj as Process).Id;
                else
                    return (obj as ProcessObject).Id;
            }
            else
            {
                if (obj.GetType() == typeof(Process))
                    return (obj as Process).ProcessName.GetHashCode() ^ (obj as Process).Id;
                else
                    return (obj as ProcessObject).ProcessName.GetHashCode() ^ (obj as ProcessObject).Id;
            }
        }


    }



}
