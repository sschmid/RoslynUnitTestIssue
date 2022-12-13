using System;
using System.Linq;
using NSpec;
using NSpec.Domain;
using NSpec.Domain.Formatters;

var tagOrClassName = string.Join(",", args);
var types = typeof(Program).Assembly.GetTypes();
var finder = new SpecFinder(types, string.Empty);
var tagsFilter = new Tags().Parse(tagOrClassName);
var builder = new ContextBuilder(finder, tagsFilter, new DefaultConventions());
var runner = new ContextRunner(tagsFilter, new ConsoleFormatter(), false);
var results = runner.Run(builder.Contexts().Build());
Environment.Exit(results.Failures().Count());
