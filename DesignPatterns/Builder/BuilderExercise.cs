﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class BuilderExercise
    {
    }
    /*
    class Field
    {
        public string Type, Name;

        public override string ToString()
        {
            return $"public {Type} {Name}";
        }
    }

    class Class
    {
        public string Name;
        public List<Field> Fields = new List<Field>();

        public Class()
        {
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {Name}").AppendLine("{");
            foreach (var f in Fields)
                sb.AppendLine($"  {f};");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class CodeBuilder
    {
        public CodeBuilder(string rootName)
        {
            theClass.Name = rootName;
        }

        public CodeBuilder AddField(string name, string type)
        {
            theClass.Fields.Add(new Field{Name = name, Type = type});
            return this;
        }

        public override string ToString()
        {
            return theClass.ToString();
        }

        private Class theClass = new Class();
    }


    public class ExcerciseBuilder
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
    */
}
