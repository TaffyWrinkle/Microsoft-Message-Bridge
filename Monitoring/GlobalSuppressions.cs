// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Microsoft Corporation">
//   Copyright 2015 Microsoft Corporation. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.MSInternal", 
        "CA904:DeclareTypesInMicrosoftOrSystemNamespace", Scope = "namespace", 
        Target = "Microsoft.MessageBridge.Monitoring", Justification = "The correct namespace is Microsoft.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", 
        "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", 
        Target = "Microsoft.MessageBridge.Monitoring.ActivityMonitor.#Bridge", 
        Justification = "The type is immutable.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", 
        "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", 
        Target = "Microsoft.MessageBridge.Monitoring.ActivityMonitor.#Bus", Justification = "The type is immutable.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", 
        "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", 
        Target = "Microsoft.MessageBridge.Monitoring.ActivityMonitor.#Publisher", 
        Justification = "The type is immutable.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", 
        "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", 
        Target = "Microsoft.MessageBridge.Monitoring.ActivityMonitor.#Subscriber", 
        Justification = "The type is immutable.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", 
        "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", 
        Target = "Microsoft.MessageBridge.Monitoring.ActivityMonitor.#Worker", 
        Justification = "The type is immutable.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", 
        "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", 
        Target = "Microsoft.MessageBridge.Monitoring.ActivityMonitorBase`1.#.ctor()", 
        Justification = "This behavior is intentional to accomodate unit testing.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", 
        Scope = "member", Target = "Microsoft.MessageBridge.Monitoring.EspActivityMonitor.#Initialize()", 
        Justification =
            "Because of the plugin nature of ActivityListener and what each listener could do in its initialize method, the monitor has no idea what exceptions to catch")]