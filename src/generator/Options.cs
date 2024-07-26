﻿using CommandLine;

namespace OriginLab.DocumentGeneration;

public class Options
{
    [Option('i', HelpText = "Only generate index pages, for fast iterations.")]
    public bool IndexPagesOnly { get; set; }

    [Value(0, Required = true, HelpText = "The folder path to the books.")]
    public required string SourcePath { get; set; }

    [Value(1, Required = true, HelpText = "The folder path to the outpot.")]
    public required string OutputPath { get; set; }
}