﻿using Hypercube.Core.Execution.Attributes;
using Hypercube.Core.Execution.Enums;
using Hypercube.Graphics.Patching;
using Hypercube.Utilities.Dependencies;

namespace Rainclipse;

public static class EntryPoint
{
    [EntryPoint(EntryPointLevel.BeforeInit)]
    public static void Init(DependenciesContainer container)
    {
        // Init
    }
    
    [EntryPoint(EntryPointLevel.AfterInit)]
    public static void Start(DependenciesContainer container)
    {
        var patchManager = container.Resolve<IPatchManager>();
        var patch = new TestPatch();
        patchManager.AddPatch(patch);
    }
}