﻿var s = "\"";
var a = @"Console.Write($";
var b = @"var s = {s}\\{s}{s};\r\nvar a = @{s}{a}{s};\r\nvar b = @{s}{b}{s};\r\nvar c = @{s}{c}{s};\r\n{a+s+b+s+c}";
var c = @");";
Console.Write($"var s = {s}\\{s}{s};\r\nvar a = @{s}{a}{s};\r\nvar b = @{s}{b}{s};\r\nvar c = @{s}{c}{s};\r\n{a+s+b+s+c}");