// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using System;
using System.Globalization;
/// <summary>
/// UnicodeCategory.ConnectorPunctuation [v-minch]
/// </summary>
public class UnicodeCategoryConnectorPunctuation
{
    public static int Main()
    {
        UnicodeCategoryConnectorPunctuation unicodeConnectPunc = new UnicodeCategoryConnectorPunctuation();
        TestLibrary.TestFramework.BeginTestCase("UnicodeCategoryConnectorPunctuation");
        if (unicodeConnectPunc.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }
    #region PositiveTest
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1:Return the ConnectorPunctuation Value in UnicodeCategory Enumerator");
        try
        {
            UnicodeCategory myUnicodeCategory = UnicodeCategory.ConnectorPunctuation;
            if (myUnicodeCategory != (UnicodeCategory)18)
            {
                TestLibrary.TestFramework.LogError("001", "the ExpectResult is 18 but the ActualResult is " + myUnicodeCategory.GetHashCode());
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    #endregion
}