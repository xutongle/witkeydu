﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
//	   如存在本生成代码外的新需求，请在相同命名空间下创建同名分部类进行实现。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Composition;
using System.Linq;

using WitKeyDu.Component.Data;
using WitKeyDu.Core.Models.Files;


namespace WitKeyDu.Core.Data.Repositories.Files.Impl
{
	/// <summary>
    ///   仓储操作层实现——论坛帖类型记录信息
    /// </summary>
    [Export(typeof(IFileTypeRepository))]
    public partial class FileTypeRepository : EFRepositoryBase<FileType, Int32>, IFileTypeRepository
    { }
}
