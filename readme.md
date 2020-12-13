Using version `EntityFrameworkCore.SqlServer.HierarchyId 2.1.0` with ef core sql server version `Microsoft.EntityFrameworkCore.SqlServer 5.0.1`, get build error:

> ReproDbContext.cs(10, 49): [CS1705] Assembly 'EntityFrameworkCore.SqlServer.HierarchyId' with identity 'EntityFrameworkCore.SqlServer.HierarchyId, Version=2.1.0.0, Culture=neutral, PublicKeyToken=0c30ba8633cb7b1e' uses 'Microsoft.EntityFrameworkCore.SqlServer, Version=42.42.42.42, Culture=neutral, PublicKeyToken=adb9793829ddae60' which has a higher version than referenced assembly 'Microsoft.EntityFrameworkCore.SqlServer' with identity 'Microsoft.EntityFrameworkCore.SqlServer, Version=5.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'

Should be able to checkout, restore nuget and build solution.