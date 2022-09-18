# CabWalk

This is the CAB Walkthrough QuickStart ported to .NET 6.0.  Think of this as a 'Hello CAB' type application, the simplest possible program that uses CAB.

The original Microsoft Patterns & Practices solution had 4 different projects (one for each step).  This git repo has different commits for the steps.
1. Step 1
    * check out commit [4d636ca](https://github.com/bradubv/CabWalk/commit/4d636cac4f4c600512118118e595a0a09011252a)
    * Simplest possible program that includes the CAB Framework, but doesn't really use it.
1. Step 2
    * check out commit [277f733](https://github.com/bradubv/CabWalk/commit/277f733802676fd48561cb58ba58ef3db3af3440)
    * Loads a module.  Puts out a dialog box to prove the module was loaded.
1. Step 3
    * check out commit [c3809d8](https://github.com/bradubv/CabWalk/commit/c3809d8ffba36513eaea1799d7a841f401968efb)
    * Add a SplitContainer and a TabWorkspace to the first (left) panel of that container in the Shell (main) Form.
1. Step 4
    * check out commit []()
    * The module now has a view that displays a message.

Until I figure out how to publish the CAB nuget packages, you can build them from source
1. [Cnt.CompositeUI.WinForms](https://github.com/bradubv/CompositeUI.WinForms) depends on
1. [Cnt.CompositeUI](https://github.com/bradubv/CompositeUI) which in turn depends on
1. [Cnt.ObjectBuilder](https://github.com/bradubv/NewObjectBuilder)