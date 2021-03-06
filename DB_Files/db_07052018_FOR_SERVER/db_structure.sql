USE [AGC]
GO
/****** Object:  Schema [ACCOUNTING]    Script Date: 7/5/2018 3:33:56 PM ******/
CREATE SCHEMA [ACCOUNTING]
GO
/****** Object:  Schema [INVENTORY]    Script Date: 7/5/2018 3:33:56 PM ******/
CREATE SCHEMA [INVENTORY]
GO
/****** Object:  Schema [MASTER]    Script Date: 7/5/2018 3:33:56 PM ******/
CREATE SCHEMA [MASTER]
GO
/****** Object:  Schema [TRANSACTION]    Script Date: 7/5/2018 3:33:56 PM ******/
CREATE SCHEMA [TRANSACTION]
GO
/****** Object:  Schema [UTIL]    Script Date: 7/5/2018 3:33:56 PM ******/
CREATE SCHEMA [UTIL]
GO
/****** Object:  Schema [xSys]    Script Date: 7/5/2018 3:33:56 PM ******/
CREATE SCHEMA [xSys]
GO
/****** Object:  Table [ACCOUNTING].[Chart_Of_Account]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ACCOUNTING].[Chart_Of_Account](
	[accountNumber] [int] NOT NULL,
	[accountName] [nvarchar](50) NOT NULL,
	[accountCategory] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Chart_Of_Account] PRIMARY KEY CLUSTERED 
(
	[accountNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [INVENTORY].[Branches]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [INVENTORY].[Branches](
	[branchInventoryID] [int] IDENTITY(1,1) NOT NULL,
	[branchCode] [nvarchar](10) NULL,
	[itemCode] [nvarchar](7) NULL,
	[tStockBeginning] [int] NULL,
	[tStockIn] [int] NULL,
	[tStockOut] [int] NULL,
	[tStockAdjustmentIn] [int] NULL,
	[tStockAdjustmentOut] [int] NULL,
	[tStockEnding] [int] NULL,
	[tStockBalance] [int] NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[branchInventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [MASTER].[Branches]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [MASTER].[Branches](
	[branchID] [int] IDENTITY(1,1) NOT NULL,
	[branchCode] [nvarchar](10) NOT NULL,
	[branchName] [nvarchar](75) NOT NULL,
	[branchAddress] [nvarchar](100) NULL,
	[branchContactNumbers] [nvarchar](50) NULL,
	[branchInchargeID] [nvarchar](50) NULL,
	[supervisorID] [int] NULL,
	[openingDate] [date] NOT NULL,
	[partnerCode] [nvarchar](10) NULL,
	[areaID] [int] NULL,
	[lessorName] [nvarchar](70) NULL,
	[modePaymentCode] [nvarchar](2) NULL,
	[paymentDate] [nvarchar](100) NULL,
	[paymentDay] [int] NULL CONSTRAINT [DF_Branches_paymentDay]  DEFAULT ((0)),
	[remarks] [nvarchar](250) NULL,
	[isActive] [bit] NOT NULL CONSTRAINT [DF_Branch_isActive]  DEFAULT ((1)),
	[DI] [datetime] NULL CONSTRAINT [DF_Branches_DI]  DEFAULT (getdate()),
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[branchCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [MASTER].[Branches_Machine_Equipment]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [MASTER].[Branches_Machine_Equipment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[branchCode] [nvarchar](10) NOT NULL,
	[machEquipCode] [nvarchar](3) NOT NULL,
	[addtDescription] [nvarchar](70) NULL,
	[serial] [nvarchar](50) NULL,
	[dateIssue] [datetime] NULL,
	[isDeleted] [bit] NOT NULL,
	[deletedRemarks] [nvarchar](150) NULL,
	[deletedDate] [datetime] NULL,
	[DI] [datetime] NULL,
 CONSTRAINT [PK_Branches_Machine_Equipment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [MASTER].[DM_Item_MF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [MASTER].[DM_Item_MF](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemDescription] [nvarchar](250) NULL,
	[UOM] [nvarchar](10) NULL,
	[ItemGroupCode] [nvarchar](2) NULL,
	[DI] [datetime] NULL CONSTRAINT [DF_DM_Item_MF_DI]  DEFAULT (getdate()),
	[DU] [datetime] NULL CONSTRAINT [DF_DM_Item_MF_DU]  DEFAULT (getdate()),
	[UserCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_Item_MF] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [MASTER].[Items]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [MASTER].[Items](
	[itemID] [int] IDENTITY(1,1) NOT NULL,
	[itemCode] [nvarchar](7) NOT NULL,
	[itemName] [nvarchar](50) NOT NULL,
	[itemCategoryCode] [nvarchar](3) NOT NULL,
	[itemUomInventory] [nvarchar](5) NULL,
	[itemUomSelling] [nvarchar](5) NULL,
	[itemStatus] [bit] NOT NULL CONSTRAINT [DF_Items_itemStatus]  DEFAULT ((1)),
	[arr] [nvarchar](2) NULL,
	[accountGroup] [nvarchar](3) NULL,
	[unitCost] [float] NULL CONSTRAINT [DF_Items_unitCost]  DEFAULT ((0)),
	[unitPrice] [float] NULL CONSTRAINT [DF_Items_unitPrice]  DEFAULT ((0)),
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[itemCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [MASTER].[Partners]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [MASTER].[Partners](
	[partnerID] [int] IDENTITY(1,1) NOT NULL,
	[partnerCode] [nvarchar](10) NOT NULL,
	[partnerName] [nvarchar](70) NOT NULL,
	[isActive] [bit] NULL CONSTRAINT [DF_Partners_isActive]  DEFAULT ((1)),
 CONSTRAINT [PK_Partners] PRIMARY KEY CLUSTERED 
(
	[partnerCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [TRANSACTION].[Branches]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TRANSACTION].[Branches](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[branchCode] [nvarchar](10) NOT NULL,
	[referenceNum] [nvarchar](13) NOT NULL,
	[itemCode] [nvarchar](10) NOT NULL,
	[Stock_In] [int] NOT NULL CONSTRAINT [DF_Branches_Stock_In]  DEFAULT ((0)),
	[Stock_Out] [int] NOT NULL CONSTRAINT [DF_Branches_Stock_Out]  DEFAULT ((0)),
	[Adj_In] [int] NOT NULL CONSTRAINT [DF_Branches_Adj_In]  DEFAULT ((0)),
	[Adj_Out] [int] NOT NULL CONSTRAINT [DF_Branches_Adj_Out]  DEFAULT ((0)),
	[Trans_In] [int] NOT NULL CONSTRAINT [DF_Branches_Trans_In]  DEFAULT ((0)),
	[Trans_Out] [int] NOT NULL CONSTRAINT [DF_Branches_Trans_Out]  DEFAULT ((0)),
	[dateSpecify] [datetime] NOT NULL CONSTRAINT [DF_Branches_dateSpecify]  DEFAULT (getdate()),
	[dateTrans] [datetime] NOT NULL CONSTRAINT [DF_Branches_dateTrans]  DEFAULT (getdate()),
 CONSTRAINT [PK_Branches_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [TRANSACTION].[Deliveries_Hdr]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TRANSACTION].[Deliveries_Hdr](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[branchCode] [nvarchar](10) NOT NULL,
	[deliveryNum] [nvarchar](12) NOT NULL,
	[deliveryDate] [datetime] NOT NULL CONSTRAINT [DF_Deliveries_Hdr_deliveryDate]  DEFAULT (getdate()),
	[remarks] [nvarchar](150) NULL,
	[DI] [datetime] NULL CONSTRAINT [DF_Deliveries_Hdr_DI]  DEFAULT (getdate()),
 CONSTRAINT [PK_Deliveries_Hdr] PRIMARY KEY CLUSTERED 
(
	[deliveryNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [TRANSACTION].[Deliveries_Line]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TRANSACTION].[Deliveries_Line](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[deliveryNum] [nvarchar](12) NOT NULL,
	[itemCode] [nvarchar](10) NOT NULL,
	[quantity] [int] NOT NULL CONSTRAINT [DF_Deliveries_Line_quantity]  DEFAULT ((0)),
	[DI] [datetime] NOT NULL CONSTRAINT [DF_Deliveries_Line_DI]  DEFAULT (getdate()),
 CONSTRAINT [PK_Deliveries_Line] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [TRANSACTION].[DM_Request_Header]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TRANSACTION].[DM_Request_Header](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DMRNum] [nvarchar](15) NOT NULL,
	[DateRequest] [datetime] NOT NULL,
	[BranchCode] [nvarchar](10) NOT NULL,
	[SupervisorID] [int] NOT NULL,
	[IsCompleted] [bit] NOT NULL,
	[IsCancel] [bit] NOT NULL,
	[IsPrint] [bit] NOT NULL,
	[IsOpen] [bit] NOT NULL,
	[IsPosted] [bit] NOT NULL,
	[IsDispatch] [bit] NOT NULL,
	[TotalAmountPrice] [float] NULL,
	[Requester_Notes] [nvarchar](250) NULL,
	[Approver_Notes] [nvarchar](250) NULL,
	[Approve_By] [nvarchar](25) NULL,
	[Dispatch_Date] [datetime] NULL,
	[Dispatch_Person] [nvarchar](70) NULL,
	[DU] [datetime] NOT NULL,
	[DI] [datetime] NULL,
	[Remarks_Trail] [nvarchar](250) NOT NULL,
	[UserCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_DebitMemoRequest_Header_TF] PRIMARY KEY CLUSTERED 
(
	[DMRNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [TRANSACTION].[DM_Request_Line]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TRANSACTION].[DM_Request_Line](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DMRNum] [nvarchar](15) NULL,
	[ItemID] [int] NOT NULL,
	[ItemDescription] [nvarchar](150) NOT NULL,
	[Quantity] [float] NULL,
	[UnitPrice] [float] NULL,
	[Amount] [float] NOT NULL,
	[OthersDetail] [nvarchar](150) NULL,
	[Attachment] [image] NULL,
	[DateRequest] [datetime] NULL,
	[RequestStatus] [nvarchar](2) NULL,
	[DateApproved] [datetime] NULL,
	[DI] [datetime] NULL,
	[IsAttachment] [bit] NULL,
 CONSTRAINT [PK_DebitMemoRequest_TF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [TRANSACTION].[Items]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TRANSACTION].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[itemCode] [nvarchar](10) NOT NULL,
	[referenceNum] [nvarchar](13) NOT NULL,
	[quantity] [int] NOT NULL,
	[invCountType] [bit] NOT NULL,
	[dateTrans] [datetime] NULL,
 CONSTRAINT [PK_Items_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Branch_Area]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Branch_Area](
	[AreaID] [int] IDENTITY(1,1) NOT NULL,
	[AreaName] [nvarchar](150) NOT NULL,
	[position] [int] NULL,
	[IsActive] [bit] NOT NULL CONSTRAINT [DF_Branch_Area_IsActive]  DEFAULT ((1)),
 CONSTRAINT [PK_Branch_Area] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Branch_Incharge_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Branch_Incharge_RF](
	[branchInchargeID] [int] IDENTITY(1,1) NOT NULL,
	[branchInchargeName] [nvarchar](75) NOT NULL,
	[isActive] [bit] NOT NULL CONSTRAINT [DF_Branch_Incharge_RF_isActive]  DEFAULT ((1)),
 CONSTRAINT [PK_Branch_Incharge_RF] PRIMARY KEY CLUSTERED 
(
	[branchInchargeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Days_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Days_RF](
	[day] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[DM_Request_Status_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[DM_Request_Status_RF](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RequestStatus] [nvarchar](1) NOT NULL,
	[RequestDescription] [nvarchar](50) NULL,
	[Type] [bit] NULL CONSTRAINT [DF_Request_Status_RF_Type]  DEFAULT ((1)),
 CONSTRAINT [PK_Request_Status_RF] PRIMARY KEY CLUSTERED 
(
	[RequestStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Item_Categories_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Item_Categories_RF](
	[itemCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[itemCategoryCode] [nvarchar](3) NOT NULL,
	[itemCategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Item_Categories_RF] PRIMARY KEY CLUSTERED 
(
	[itemCategoryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Item_Group_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Item_Group_RF](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[ItemGroupCode] [nvarchar](3) NOT NULL,
	[groupName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ItemGroup_RF] PRIMARY KEY CLUSTERED 
(
	[ItemGroupCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Machine_Equipment_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Machine_Equipment_RF](
	[MachEquipID] [int] IDENTITY(1,1) NOT NULL,
	[MachEquipCode] [nvarchar](3) NOT NULL,
	[MachEquipName] [nvarchar](75) NOT NULL,
	[MachEquipType] [nvarchar](1) NULL,
 CONSTRAINT [PK_Machine_Equipment_RF] PRIMARY KEY CLUSTERED 
(
	[MachEquipCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Mode_Payment_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Mode_Payment_RF](
	[paymentModeCode] [nvarchar](2) NOT NULL,
	[paymentModeName] [nvarchar](50) NOT NULL,
	[arr] [nvarchar](2) NULL,
 CONSTRAINT [PK_Mode_Payment_RF] PRIMARY KEY CLUSTERED 
(
	[paymentModeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Reports_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Reports_RF](
	[reportID] [int] IDENTITY(1,1) NOT NULL,
	[reportDescription] [nvarchar](100) NOT NULL,
	[reportFileName] [nvarchar](100) NULL,
	[reportGroup] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Reports_RF] PRIMARY KEY CLUSTERED 
(
	[reportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Status_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Status_RF](
	[statusCode] [nvarchar](2) NOT NULL,
	[statusName] [nvarchar](20) NULL,
 CONSTRAINT [PK_Status_RF] PRIMARY KEY CLUSTERED 
(
	[statusCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[Supervisor_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[Supervisor_RF](
	[supervisorID] [int] IDENTITY(1,1) NOT NULL,
	[supervisorName] [nvarchar](70) NOT NULL,
	[isActive] [bit] NOT NULL CONSTRAINT [DF_Supervisor_RF_isActive]  DEFAULT ((1)),
	[DI] [datetime] NULL CONSTRAINT [DF_Supervisor_RF_DI]  DEFAULT (getdate()),
	[DU] [datetime] NULL CONSTRAINT [DF_Supervisor_RF_DU]  DEFAULT (getdate()),
	[userCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_Supervisor_RF] PRIMARY KEY CLUSTERED 
(
	[supervisorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [UTIL].[UnitOfMeasurement_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [UTIL].[UnitOfMeasurement_RF](
	[uomID] [int] IDENTITY(1,1) NOT NULL,
	[uomCode] [nvarchar](4) NULL,
	[uomDescription] [nvarchar](80) NULL,
	[DI] [datetime] NULL CONSTRAINT [DF_UnitOfMeasurement_RF_DI]  DEFAULT (getdate()),
	[DU] [datetime] NULL CONSTRAINT [DF_UnitOfMeasurement_RF_DU]  DEFAULT (getdate()),
	[userCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_UnitOfMeasurement] PRIMARY KEY CLUSTERED 
(
	[uomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [xSys].[DM_Audit_logs]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [xSys].[DM_Audit_logs](
	[auditID] [int] IDENTITY(1,1) NOT NULL,
	[action] [nvarchar](50) NOT NULL,
	[module] [nvarchar](50) NOT NULL,
	[description] [nvarchar](150) NULL,
	[di] [datetime] NOT NULL,
	[usercode] [nvarchar](20) NULL,
 CONSTRAINT [PK_DM_Audit_logs] PRIMARY KEY CLUSTERED 
(
	[auditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [xSys].[Menu_MF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [xSys].[Menu_MF](
	[menuID] [int] NOT NULL,
	[menuText] [nvarchar](30) NULL,
	[url] [nvarchar](50) NULL,
	[parentMenuID] [int] NULL,
	[position] [nvarchar](10) NULL,
	[arr] [nvarchar](3) NULL,
	[flgChild] [bit] NOT NULL CONSTRAINT [DF_Menu_MF_flgChild]  DEFAULT ((0)),
	[active] [bit] NOT NULL CONSTRAINT [DF_Menu_MF_active]  DEFAULT ((1)),
 CONSTRAINT [PK_Menu_MF] PRIMARY KEY CLUSTERED 
(
	[menuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [xSys].[SeriesNumber_RF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [xSys].[SeriesNumber_RF](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PrefixCode] [nvarchar](5) NOT NULL,
	[PrefixAppend] [nvarchar](5) NULL,
	[Description] [nvarchar](150) NULL,
	[Series] [int] NULL CONSTRAINT [DF_SeriesNumber_RF_Series]  DEFAULT ((0)),
	[IsNumberOnly] [bit] NULL CONSTRAINT [DF_SeriesNumber_RF_IsNumberOnly]  DEFAULT ((0)),
 CONSTRAINT [PK_SeriesNumber_RF] PRIMARY KEY CLUSTERED 
(
	[PrefixCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [xSys].[User_MF]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [xSys].[User_MF](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [nvarchar](15) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](25) NOT NULL,
	[Account_Type_Code] [nvarchar](2) NOT NULL CONSTRAINT [DF_User_MF_Account_Type_Code]  DEFAULT (N'U'),
	[FlgStatus] [bit] NOT NULL CONSTRAINT [DF_User_MF_FlgStatus]  DEFAULT ((1)),
	[LastLog] [datetime] NULL CONSTRAINT [DF_User_MF_LastLog]  DEFAULT (getdate()),
	[DMTAccess] [bit] NULL CONSTRAINT [DF_User_MF_DMTAccess]  DEFAULT ((0)),
	[DI] [datetime] NULL CONSTRAINT [DF_User_MF_DI]  DEFAULT (getdate()),
 CONSTRAINT [PK_User_MF] PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [TRANSACTION].[VR_BRANCH_DELIVERY_RECEIPT_SINGLE]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [TRANSACTION].[VR_BRANCH_DELIVERY_RECEIPT_SINGLE]
AS
SELECT        MASTER.Branches.branchName, MASTER.Branches.branchAddress, MASTER.Branches.branchContactNumbers, UTIL.Supervisor_RF.supervisorName, UTIL.Branch_Incharge_RF.branchInchargeName, 
                         [TRANSACTION].Deliveries_Hdr.deliveryNum, [TRANSACTION].Deliveries_Hdr.deliveryDate, [TRANSACTION].Deliveries_Hdr.remarks, [TRANSACTION].Deliveries_Hdr.DI, MASTER.Items.itemCode, MASTER.Items.itemName, 
                         [TRANSACTION].Deliveries_Line.quantity, MASTER.Items.arr, MASTER.Branches.branchCode
FROM            MASTER.Items INNER JOIN
                         [TRANSACTION].Deliveries_Line ON MASTER.Items.itemCode = [TRANSACTION].Deliveries_Line.itemCode INNER JOIN
                         MASTER.Branches INNER JOIN
                         [TRANSACTION].Deliveries_Hdr ON MASTER.Branches.branchCode = [TRANSACTION].Deliveries_Hdr.branchCode ON 
                         [TRANSACTION].Deliveries_Line.deliveryNum = [TRANSACTION].Deliveries_Hdr.deliveryNum LEFT OUTER JOIN
                         UTIL.Branch_Incharge_RF ON MASTER.Branches.branchInchargeID = UTIL.Branch_Incharge_RF.branchInchargeID LEFT OUTER JOIN
                         UTIL.Supervisor_RF ON MASTER.Branches.supervisorID = UTIL.Supervisor_RF.supervisorID

GO
/****** Object:  View [TRANSACTION].[VR_DM_RECEIPT]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [TRANSACTION].[VR_DM_RECEIPT]
AS
SELECT        [TRANSACTION].DM_Request_Line.DMRNum, [TRANSACTION].DM_Request_Line.Quantity, [TRANSACTION].DM_Request_Line.ItemID, [TRANSACTION].DM_Request_Line.Amount, 
                         [TRANSACTION].DM_Request_Line.OthersDetail, [TRANSACTION].DM_Request_Header.DateRequest, [TRANSACTION].DM_Request_Header.BranchCode, [TRANSACTION].DM_Request_Header.SupervisorID, 
                         [TRANSACTION].DM_Request_Header.Approver_Notes, [TRANSACTION].DM_Request_Header.Requester_Notes, UTIL.Supervisor_RF.supervisorName, MASTER.Branches.branchName, 
                         [TRANSACTION].DM_Request_Line.ItemDescription, [TRANSACTION].DM_Request_Line.RequestStatus, xSys.User_MF.UserName, [TRANSACTION].DM_Request_Line.DI, [TRANSACTION].DM_Request_Line.UnitPrice, 
                         [TRANSACTION].DM_Request_Header.IsDispatch, [TRANSACTION].DM_Request_Header.Dispatch_Date, [TRANSACTION].DM_Request_Header.Dispatch_Person
FROM            MASTER.Branches INNER JOIN
                         [TRANSACTION].DM_Request_Header ON MASTER.Branches.branchCode = [TRANSACTION].DM_Request_Header.BranchCode INNER JOIN
                         [TRANSACTION].DM_Request_Line ON [TRANSACTION].DM_Request_Header.DMRNum = [TRANSACTION].DM_Request_Line.DMRNum INNER JOIN
                         MASTER.DM_Item_MF ON [TRANSACTION].DM_Request_Line.ItemID = MASTER.DM_Item_MF.ItemID INNER JOIN
                         UTIL.Supervisor_RF ON [TRANSACTION].DM_Request_Header.SupervisorID = UTIL.Supervisor_RF.supervisorID INNER JOIN
                         xSys.User_MF ON [TRANSACTION].DM_Request_Header.UserCode = xSys.User_MF.UserCode

GO
/****** Object:  View [TRANSACTION].[VR_DM_REQUEST_STATUS_MONITORING]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [TRANSACTION].[VR_DM_REQUEST_STATUS_MONITORING]
AS
SELECT        [TRANSACTION].DM_Request_Header.DMRNum, [TRANSACTION].DM_Request_Header.DateRequest, MASTER.Branches.branchName, UTIL.Supervisor_RF.supervisorName, [TRANSACTION].DM_Request_Line.ItemDescription, 
                         [TRANSACTION].DM_Request_Line.Quantity, [TRANSACTION].DM_Request_Line.UnitPrice, [TRANSACTION].DM_Request_Line.Amount, [TRANSACTION].DM_Request_Line.OthersDetail, 
                         [TRANSACTION].DM_Request_Line.RequestStatus, [TRANSACTION].DM_Request_Line.DateApproved, UTIL.DM_Request_Status_RF.RequestDescription
FROM            MASTER.Branches INNER JOIN
                         [TRANSACTION].DM_Request_Header ON MASTER.Branches.branchCode = [TRANSACTION].DM_Request_Header.BranchCode INNER JOIN
                         [TRANSACTION].DM_Request_Line ON [TRANSACTION].DM_Request_Header.DMRNum = [TRANSACTION].DM_Request_Line.DMRNum INNER JOIN
                         UTIL.Supervisor_RF ON [TRANSACTION].DM_Request_Header.SupervisorID = UTIL.Supervisor_RF.supervisorID LEFT OUTER JOIN
                         UTIL.DM_Request_Status_RF ON [TRANSACTION].DM_Request_Line.RequestStatus = UTIL.DM_Request_Status_RF.RequestStatus

GO
INSERT [ACCOUNTING].[Chart_Of_Account] ([accountNumber], [accountName], [accountCategory]) VALUES (101, N'Cash on Hand', N'Asset')
INSERT [ACCOUNTING].[Chart_Of_Account] ([accountNumber], [accountName], [accountCategory]) VALUES (110, N'Account Receivable', N'Asset')
INSERT [ACCOUNTING].[Chart_Of_Account] ([accountNumber], [accountName], [accountCategory]) VALUES (140, N'Supplies', N'Expense')
INSERT [ACCOUNTING].[Chart_Of_Account] ([accountNumber], [accountName], [accountCategory]) VALUES (200, N'Account Payable', N'Liability')
INSERT [ACCOUNTING].[Chart_Of_Account] ([accountNumber], [accountName], [accountCategory]) VALUES (410, N'Product Sales Revenue', N'Revenue')
SET IDENTITY_INSERT [MASTER].[Branches] ON 

INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (1, N'JMR1001', N'CALENDOLA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:10.900' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (2, N'JMR1002', N'GMA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:10.930' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (3, N'JMR1003', N'BULIHAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:10.957' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (4, N'JMR1004', N'SAN JOSE - GMA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:10.980' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (5, N'JMR1005', N'MAGRA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.007' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (6, N'JMR1006', N'GRANADOS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.030' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (7, N'JMR1007', N'GEN. TRIAS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.053' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (8, N'JMR1008', N'CASIMIRO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.080' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (9, N'JMR1009', N'EVACOM', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.103' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (10, N'JMR1010', N'PAMPLONA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.130' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (11, N'JMR1011', N'SAMPALOC', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.153' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (12, N'JMR1012', N'BACOOR', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.177' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (13, N'JMR1013', N'SAN NICOLAS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.200' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (14, N'JMR1014', N'ALABANG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.223' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (15, N'JMR1015', N'BULI', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.250' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (16, N'JMR1016', N'M. ALVAREZ', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.273' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (17, N'JMR1017', N'MOONWALK', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.297' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (18, N'JMR1018', N'MUNTI', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.320' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (19, N'JMR1019', N'PUTATAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.343' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (20, N'JMR1020', N'SUCAT EXIT', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.367' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (21, N'JMR1021', N'TUNASAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.390' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (22, N'JMR1022', N'BATASAN 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.410' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (23, N'JMR1023', N'AREA E', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.437' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (24, N'JMR1024', N'AREA G', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.460' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (25, N'JMR1025', N'D. BAYAN 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.483' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (26, N'JMR1026', N'D. BAYAN 2', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.507' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (27, N'JMR1027', N'KADIWA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.530' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (28, N'JMR1028', N'LA SALLE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.553' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (29, N'JMR1029', N'LANGKAAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.577' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (30, N'JMR1030', N'BALIWAG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.600' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (31, N'JMR1031', N'CABANATUAN 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.627' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (32, N'JMR1032', N'DAGUPAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.650' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (33, N'JMR1033', N'OLONGAPO 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.673' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (34, N'JMR1034', N'OLONGAPO 2', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.697' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (35, N'JMR1035', N'PLARIDEL', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.720' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (36, N'JMR1036', N'STA. RITA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.743' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (37, N'JMR1037', N'GUADALOPE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.767' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (38, N'JMR1038', N'MANDALUYONG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.790' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (39, N'JMR1039', N'SHAW BLVD.', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.817' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (40, N'JMR1040', N'LOWER BICUTAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.840' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (41, N'JMR1041', N'MASINAG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.867' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (42, N'JMR1042', N'MERCEDES', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.890' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (43, N'JMR1043', N'PINAGBUHATAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.913' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (44, N'JMR1044', N'ROSARIO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.937' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (45, N'JMR1045', N'TAGUIG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.960' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (46, N'JMR1046', N'ROTONDA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:11.983' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (47, N'JMR1047', N'ANABU', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.007' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (48, N'JMR1048', N'MALABON GT', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.030' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (49, N'JMR1049', N'BINAKAYAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.057' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (50, N'JMR1050', N'IMUS 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.080' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (51, N'JMR1051', N'IMUS 2', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.103' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (52, N'JMR1052', N'SM BACOOR', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.127' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (53, N'JMR1053', N'D. SALITRAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.150' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (54, N'JMR1054', N'CALOOCAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.173' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (55, N'JMR1055', N'F. MALABON', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.200' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (56, N'JMR1056', N'FATIMA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.223' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (57, N'JMR1057', N'MALINTA EXIT', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.247' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (58, N'JMR1058', N'MALINTA HIWAY', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.270' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (59, N'JMR1059', N'PAJO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.293' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (60, N'JMR1060', N'SANGANDAAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.317' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (61, N'JMR1061', N'U.E', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.340' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (62, N'JMR1062', N'PROJECT 8', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.363' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (63, N'JMR1063', N'TANDANG SORA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.387' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (64, N'JMR1064', N'ARRAYAT', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.410' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (65, N'JMR1065', N'STO. DOMINGO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.433' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (66, N'JMR1066', N'ESPAÑA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.460' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (67, N'JMR1067', N'AP REYES', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'JMR   ', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:12.483' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (138, N'LAG1001', N'ZAPOTE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.750' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (139, N'LAG1002', N'SUCAT LOPEZ', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.813' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (140, N'LAG1003', N'11TH AVENUE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.840' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (141, N'LAG1004', N'MONUMENTO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.867' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (142, N'LAG1005', N'STA. MESA OLD', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.893' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (143, N'LAG1006', N'KAINGIN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.920' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (144, N'LAG1007', N'SAN JUAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.943' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (145, N'LAG1008', N'VISAYAS 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.967' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (146, N'LAG1009', N'VISAYAS 2', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LAG', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:34.990' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (176, N'LYO1001', N'MINDANAO AVE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.540' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (177, N'LYO1002', N'SAUYO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.570' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (178, N'LYO1003', N'MANGGAHAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.597' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (179, N'LYO1004', N'LITEX 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.623' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (180, N'LYO1005', N'PAYATAS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.647' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (181, N'LYO1006', N'BATASAN 4', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.673' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (182, N'LYO1007', N'BF HOMES', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.697' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (183, N'LYO1008', N'RIVERSIDE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.720' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (184, N'LYO1009', N'NAGPAYONG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.747' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (185, N'LYO1010', N'US-USAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.770' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (186, N'LYO1011', N'PALLAR', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.793' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (187, N'LYO1012', N'MCKINLEY', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.820' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (188, N'LYO1013', N'PINAGSAMA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.840' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (189, N'LYO1014', N'PEMBO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.867' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (190, N'LYO1015', N'PANGARAP', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.890' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (191, N'LYO1016', N'B. SILANG 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.913' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (192, N'LYO1017', N'B. SILANG 2', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.940' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (193, N'LYO1018', N'B. SILANG 3', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.963' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (194, N'LYO1019', N'RP QUIRINO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:48.987' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (195, N'LYO1020', N'GOODWILL', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.010' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (196, N'LYO1021', N'CAMARIN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.037' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (197, N'LYO1022', N'NOVA BAYAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.060' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (198, N'LYO1023', N'ZABARTE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.083' AS DateTime))
GO
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (199, N'LYO1024', N'B. SILANG 4', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.107' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (200, N'LYO1025', N'SAMPOL 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.133' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (201, N'LYO1026', N'SAMPOL 2', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.157' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (202, N'LYO1027', N'MALIGAYA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.180' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (203, N'LYO1028', N'SUSANO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.207' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (204, N'LYO1029', N'BAGONG BARRIO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'LYO', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:38:49.230' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (68, N'MGM1001', N'STA. ROSA HEIGHTS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.140' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (69, N'MGM1002', N'BIGA SILANG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.190' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (70, N'MGM1003', N'SILANG BAYAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.217' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (71, N'MGM1004', N'AMADEO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.243' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (72, N'MGM1005', N'D. BUKAL', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.567' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (73, N'MGM1006', N'BUHO SILANG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.593' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (74, N'MGM1007', N'AMADEO 2', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.620' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (75, N'MGM1008', N'TAGAYTAY', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.643' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (76, N'MGM1009', N'PANDACAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.667' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (77, N'MGM1010', N'STA. ANA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.690' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (78, N'MGM1011', N'CARMEN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.713' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (79, N'MGM1012', N'SAN JOSE N.E', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.740' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (80, N'MGM1013', N'LANCASTER', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.760' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (81, N'MGM1014', N'PARKLANE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.787' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (82, N'MGM1015', N'SABANG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.810' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (83, N'MGM1016', N'KARUHATAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.833' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (84, N'MGM1017', N'STA. MESA MGU', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.860' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (85, N'MGM1018', N'BAG. AIRPORT/LOAKAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.883' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (86, N'MGM1019', N'MARCOS HIWAY', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.907' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (87, N'MGM1020', N'BAG.1 QUEZON HILL', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.930' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (88, N'MGM1021', N'SAN FERNANDO 1', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.953' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (89, N'MGM1022', N'BAUANG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:25.977' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (90, N'MGM1023', N'TRANCOVILLE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.000' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (91, N'MGM1024', N'TRINIDAD NEW', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.023' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (92, N'MGM1025', N'BAYAMBANG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.050' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (93, N'MGM1026', N'BAG. IRISAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.070' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (94, N'MGM1027', N'R. PAPA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.097' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (95, N'MGM1028', N'AMORANTO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.120' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (96, N'MGM1029', N'BALIK-BALIK', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.143' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (97, N'MGM1030', N'BUSTILLOS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.167' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (98, N'MGM1031', N'GALAS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.190' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (99, N'MGM1032', N'OTIS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.213' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (100, N'MGM1033', N'QUIAPO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.240' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (101, N'MGM1034', N'DELA FUENTE', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.263' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (102, N'MGM1035', N'EDSA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.287' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (103, N'MGM1036', N'BACLARAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.310' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (104, N'MGM1037', N'EVANGELISTA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.333' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (105, N'MGM1038', N'GATE 3', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.357' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (106, N'MGM1039', N'MALIBAY', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.380' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (107, N'MGM1040', N'MARICABAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.417' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (108, N'MGM1041', N'TEJERON', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.450' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (109, N'MGM1042', N'ALICIA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.473' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (110, N'MGM1043', N'PRENZA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.500' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (111, N'MGM1044', N'AURORA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.520' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (112, N'MGM1045', N'PNB', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.547' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (113, N'MGM1046', N'VIRA ROXAS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.570' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (114, N'MGM1047', N'ROXAS', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.597' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (115, N'MGM1048', N'ALICIA NEW', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.620' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (116, N'MGM1049', N'CABARUAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.643' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (117, N'MGM1050', N'SANTIAGO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.667' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (118, N'MGM1051', N'BALIGATAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.693' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (119, N'MGM1052', N'SOLIVEN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.717' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (120, N'MGM1053', N'MARANA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.740' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (121, N'MGM1054', N'CABAGAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.767' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (122, N'MGM1055', N'TUMAUINI', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.790' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (123, N'MGM1056', N'SAN MARIANO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.813' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (124, N'MGM1057', N'GAMU/UPI', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.837' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (125, N'MGM1058', N'REINA MARCEDES', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.860' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (126, N'MGM1059', N'UGAC', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.883' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (127, N'MGM1060', N'GATTARAN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.907' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (128, N'MGM1061', N'LIBERTAD', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.933' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (129, N'MGM1062', N'BUNTON', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.957' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (130, N'MGM1063', N'NORTH TC/LIBAG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:26.980' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (131, N'MGM1064', N'SM UGAC', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:27.003' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (132, N'MGM1065', N'CARIG', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:27.027' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (133, N'MGM1066', N'BONIFACIO', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:27.050' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (134, N'MGM1067', N'BALZAIN', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:27.077' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (135, N'MGM1068', N'TANZA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:27.100' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (136, N'MGM1069', N'APARRI', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:27.123' AS DateTime))
INSERT [MASTER].[Branches] ([branchID], [branchCode], [branchName], [branchAddress], [branchContactNumbers], [branchInchargeID], [supervisorID], [openingDate], [partnerCode], [areaID], [lessorName], [modePaymentCode], [paymentDate], [paymentDay], [remarks], [isActive], [DI]) VALUES (137, N'MGM1070', N'STA. TERESITA', N'', N'', N'', NULL, CAST(N'2018-06-11' AS Date), N'MGMU', NULL, N'', NULL, NULL, 0, NULL, 1, CAST(N'2018-06-11 14:37:27.147' AS DateTime))
SET IDENTITY_INSERT [MASTER].[Branches] OFF
SET IDENTITY_INSERT [MASTER].[DM_Item_MF] ON 

INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (1, N'LEMON', N'', N'RI', CAST(N'2018-06-11 14:20:12.193' AS DateTime), CAST(N'2018-06-11 14:20:12.193' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (2, N'SILI', N'', N'RI', CAST(N'2018-06-11 14:20:12.240' AS DateTime), CAST(N'2018-06-11 14:20:12.240' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (3, N'TANGLAD', N'', N'RI', CAST(N'2018-06-11 14:20:12.277' AS DateTime), CAST(N'2018-06-11 14:20:12.277' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (4, N'ULING', N'', N'RI', CAST(N'2018-06-11 14:20:12.303' AS DateTime), CAST(N'2018-06-11 14:20:12.303' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (5, N'BASAHAN', N'', N'RI', CAST(N'2018-06-11 14:20:12.327' AS DateTime), CAST(N'2018-06-11 14:20:12.327' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (6, N'MOP', N'', N'RI', CAST(N'2018-06-11 14:20:12.350' AS DateTime), CAST(N'2018-06-11 14:20:12.350' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (7, N'ALCOHOL', N'', N'RI', CAST(N'2018-06-11 14:20:12.373' AS DateTime), CAST(N'2018-06-11 14:20:12.373' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (8, N'SABON', N'', N'RI', CAST(N'2018-06-11 14:20:12.397' AS DateTime), CAST(N'2018-06-11 14:20:12.397' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (9, N'SPONGE', N'', N'RI', CAST(N'2018-06-11 14:20:12.420' AS DateTime), CAST(N'2018-06-11 14:20:12.420' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (10, N'STEELWOOL', N'', N'RI', CAST(N'2018-06-11 14:20:12.443' AS DateTime), CAST(N'2018-06-11 14:20:12.443' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (11, N'WATER SUPPLY', N'PC', N'RI', CAST(N'2018-06-11 14:20:12.467' AS DateTime), CAST(N'2018-06-11 14:20:12.467' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (12, N'MINERAL WATER', N'', N'RI', CAST(N'2018-06-11 14:20:12.490' AS DateTime), CAST(N'2018-06-11 14:20:12.490' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (13, N'MEAL ALLOWANCE', N'', N'RI', CAST(N'2018-06-11 14:20:12.517' AS DateTime), CAST(N'2018-06-11 14:20:12.517' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (14, N'FARE ALLOWANCE', N'', N'RI', CAST(N'2018-06-11 14:20:12.540' AS DateTime), CAST(N'2018-06-11 14:20:12.540' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (15, N'TRAVEL ALLOWANCE', N'', N'RI', CAST(N'2018-06-11 14:20:12.560' AS DateTime), CAST(N'2018-06-11 14:20:12.560' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (16, N'SALES INVOICE', N'', N'RI', CAST(N'2018-06-11 14:20:12.587' AS DateTime), CAST(N'2018-06-11 14:20:12.587' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (17, N'FOOD TONG', N'', N'RI', CAST(N'2018-06-11 14:20:12.607' AS DateTime), CAST(N'2018-06-11 14:20:12.607' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (18, N'ICE CUBE', N'', N'RI', CAST(N'2018-06-11 14:20:12.630' AS DateTime), CAST(N'2018-06-11 14:20:12.630' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (19, N'ICE CANDY WRAPPER', N'', N'RI', CAST(N'2018-06-11 14:20:12.653' AS DateTime), CAST(N'2018-06-11 14:20:12.653' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (20, N'GARBAGE BAG/TRASH BAG', N'', N'RI', CAST(N'2018-06-11 14:20:12.680' AS DateTime), CAST(N'2018-06-11 14:20:12.680' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (21, N'GARBAGE FEE', N'', N'RI', CAST(N'2018-06-11 14:20:12.703' AS DateTime), CAST(N'2018-06-11 14:20:12.703' AS DateTime), N'1')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (22, N'WATER BILL', N'PC', N'UI', CAST(N'2018-06-11 14:20:12.727' AS DateTime), CAST(N'2018-06-19 10:13:51.477' AS DateTime), N'2')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (23, N'MERALCO BILL', N'PC', N'UI', CAST(N'2018-06-11 14:20:12.750' AS DateTime), CAST(N'2018-06-19 10:13:23.390' AS DateTime), N'2')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (24, N'MANUAL SALARY', N'PC', N'UI', CAST(N'2018-06-11 14:20:12.773' AS DateTime), CAST(N'2018-06-18 09:07:32.123' AS DateTime), N'2')
INSERT [MASTER].[DM_Item_MF] ([ItemID], [ItemDescription], [UOM], [ItemGroupCode], [DI], [DU], [UserCode]) VALUES (25, N'PRIVILEGE', N'NA', N'RI', CAST(N'2018-06-19 16:56:52.230' AS DateTime), CAST(N'2018-06-19 16:56:52.230' AS DateTime), N'Malou')
SET IDENTITY_INSERT [MASTER].[DM_Item_MF] OFF
SET IDENTITY_INSERT [MASTER].[Items] ON 

INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (3, N'ITM-ATS', N'ATSARA', N'IS', N'PC', N'PC', 1, N'A3', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (1, N'ITM-CHK', N'CHICKEN', N'IS', N'PC', N'PC', 1, N'A1', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (4, N'ITM-CKN', N'CHICK NECK', N'IS', N'PC', N'PC', 1, N'A4', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (5, N'ITM-FOI', N'FOIL', N'IO', N'PC', N'PC', 1, N'A5', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (8, N'ITM-KAL', N'KALAMANSI', N'IO', N'', N'', 1, N'A8', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (2, N'ITM-LIE', N'LIEMPO', N'IS', N'PC', N'PC', 1, N'A2', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (6, N'ITM-SAU', N'SAUCE', N'IO', N'PC', N'PC', 1, N'A6', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (10, N'ITM-SBT', N'SRP BOX N TIES', N'IO', N'', N'', 1, N'B1', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (9, N'ITM-SIL', N'SILI', N'IO', N'', N'', 1, N'A9', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (11, N'ITM-SPT', N'SRP TINY', N'IO', N'', N'', 1, N'B2', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (7, N'ITM-TAN', N'TANGLAD', N'IO', N'', N'', 1, N'A7', NULL, NULL, NULL)
INSERT [MASTER].[Items] ([itemID], [itemCode], [itemName], [itemCategoryCode], [itemUomInventory], [itemUomSelling], [itemStatus], [arr], [accountGroup], [unitCost], [unitPrice]) VALUES (12, N'ITM-ULI', N'ULING', N'IO', N'', N'', 1, N'B3', NULL, NULL, NULL)
SET IDENTITY_INSERT [MASTER].[Items] OFF
SET IDENTITY_INSERT [MASTER].[Partners] ON 

INSERT [MASTER].[Partners] ([partnerID], [partnerCode], [partnerName], [isActive]) VALUES (1, N'JMR', N'JOEMAR BOLONIA UNABIA', 1)
INSERT [MASTER].[Partners] ([partnerID], [partnerCode], [partnerName], [isActive]) VALUES (6, N'LAG', N'LAG', 1)
INSERT [MASTER].[Partners] ([partnerID], [partnerCode], [partnerName], [isActive]) VALUES (5, N'LYO', N'LYO', 1)
INSERT [MASTER].[Partners] ([partnerID], [partnerCode], [partnerName], [isActive]) VALUES (2, N'MGMU', N'MARY GRACE MINA UNABIA', 1)
SET IDENTITY_INSERT [MASTER].[Partners] OFF
SET IDENTITY_INSERT [TRANSACTION].[Branches] ON 

INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (1, N'BTX001', N'DRB000000004', N'ITM-CHK', 8, 0, 0, 0, 0, 0, CAST(N'2018-06-01 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:11:23.847' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (2, N'BTX001', N'DRB000000004', N'ITM-LIE', 7, 0, 0, 0, 0, 0, CAST(N'2018-06-01 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:11:23.847' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (3, N'BTX001', N'DRB000000004', N'ITM-ATS', 8, 0, 0, 0, 0, 0, CAST(N'2018-06-01 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:11:23.847' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (4, N'BTX001', N'DRB000000004', N'ITM-CKN', 50, 0, 0, 0, 0, 0, CAST(N'2018-06-01 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:11:23.850' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (5, N'BTX001', N'DRB000000004', N'ITM-SIL', 8, 0, 0, 0, 0, 0, CAST(N'2018-06-01 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:11:23.850' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (6, N'BRC101', N'DRB000000005', N'ITM-CHK', 50, 0, 0, 0, 0, 0, CAST(N'2018-06-15 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:16:45.987' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (7, N'BRC101', N'DRB000000005', N'ITM-LIE', 5, 0, 0, 0, 0, 0, CAST(N'2018-06-15 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (8, N'BRC101', N'DRB000000005', N'ITM-ATS', 9, 0, 0, 0, 0, 0, CAST(N'2018-06-15 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (9, N'BRC101', N'DRB000000005', N'ITM-CKN', 10, 0, 0, 0, 0, 0, CAST(N'2018-06-15 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (10, N'BRC101', N'DRB000000005', N'ITM-SAU', 50, 0, 0, 0, 0, 0, CAST(N'2018-06-15 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (11, N'BRC101', N'DRB000000005', N'ITM-SIL', 2, 0, 0, 0, 0, 0, CAST(N'2018-06-15 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (12, N'BRC101', N'DRB000000005', N'ITM-SBT', 35, 0, 0, 0, 0, 0, CAST(N'2018-06-15 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (13, N'BRC101', N'DRB000000006', N'ITM-CHK', 500, 0, 0, 0, 0, 0, CAST(N'2018-05-25 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:32:39.557' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (14, N'BRC101', N'DRB000000006', N'ITM-LIE', 200, 0, 0, 0, 0, 0, CAST(N'2018-05-25 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:32:39.557' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (15, N'BRC101', N'DRB000000006', N'ITM-ATS', 20, 0, 0, 0, 0, 0, CAST(N'2018-05-25 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:32:39.560' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (16, N'BRC101', N'DRB000000006', N'ITM-CKN', 80, 0, 0, 0, 0, 0, CAST(N'2018-05-25 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:32:39.560' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (17, N'BRC101', N'DRB000000006', N'ITM-TAN', 25, 0, 0, 0, 0, 0, CAST(N'2018-05-25 00:00:00.000' AS DateTime), CAST(N'2018-05-31 11:32:39.560' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (27, N'X3101', N'DRB000000008', N'ITM-CHK', 60, 0, 0, 0, 0, 0, CAST(N'2018-06-12 00:00:00.000' AS DateTime), CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (28, N'X3101', N'DRB000000008', N'ITM-LIE', 30, 0, 0, 0, 0, 0, CAST(N'2018-06-12 00:00:00.000' AS DateTime), CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (29, N'X3101', N'DRB000000008', N'ITM-FOI', 20, 0, 0, 0, 0, 0, CAST(N'2018-06-12 00:00:00.000' AS DateTime), CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (30, N'X3101', N'DRB000000008', N'ITM-SAU', 10, 0, 0, 0, 0, 0, CAST(N'2018-06-12 00:00:00.000' AS DateTime), CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (31, N'XXX1', N'DRB000000009', N'ITM-CHK', 50, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.487' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (32, N'XXX1', N'DRB000000009', N'ITM-LIE', 45, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (33, N'XXX1', N'DRB000000009', N'ITM-ATS', 40, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (34, N'XXX1', N'DRB000000009', N'ITM-CKN', 35, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (35, N'XXX1', N'DRB000000009', N'ITM-FOI', 30, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (36, N'XXX1', N'DRB000000009', N'ITM-SAU', 25, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (37, N'XXX1', N'DRB000000009', N'ITM-TAN', 20, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (38, N'XXX1', N'DRB000000009', N'ITM-KAL', 15, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.493' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (39, N'XXX1', N'DRB000000009', N'ITM-SIL', 10, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.493' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (40, N'XXX1', N'DRB000000009', N'ITM-SBT', 5, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.493' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (41, N'XXX1', N'DRB000000009', N'ITM-SPT', 4, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.493' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (42, N'XXX1', N'DRB000000009', N'ITM-ULI', 3, 0, 0, 0, 0, 0, CAST(N'2018-06-29 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:01:57.497' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (43, N'XAX', N'DRB000000010', N'ITM-CHK', 50, 0, 0, 0, 0, 0, CAST(N'2018-05-30 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (44, N'XAX', N'DRB000000010', N'ITM-LIE', 20, 0, 0, 0, 0, 0, CAST(N'2018-05-30 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (45, N'XAX', N'DRB000000010', N'ITM-ATS', 14, 0, 0, 0, 0, 0, CAST(N'2018-05-30 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (46, N'XAX', N'DRB000000010', N'ITM-CKN', 45, 0, 0, 0, 0, 0, CAST(N'2018-05-30 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (47, N'XAX', N'DRB000000010', N'ITM-FOI', 53, 0, 0, 0, 0, 0, CAST(N'2018-05-30 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (48, N'NBRAN1', N'DRB000000011', N'ITM-CHK', 20, 0, 0, 0, 0, 0, CAST(N'2018-05-25 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:46:51.963' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (49, N'NBRAN1', N'DRB000000011', N'ITM-LIE', 52, 0, 0, 0, 0, 0, CAST(N'2018-05-25 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:46:51.963' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (50, N'XAX', N'DRB000000012', N'ITM-CHK', 85, 0, 0, 0, 0, 0, CAST(N'2018-05-31 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (51, N'XAX', N'DRB000000012', N'ITM-LIE', 62, 0, 0, 0, 0, 0, CAST(N'2018-05-31 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (52, N'XAX', N'DRB000000012', N'ITM-ATS', 20, 0, 0, 0, 0, 0, CAST(N'2018-05-31 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (53, N'XAX', N'DRB000000012', N'ITM-CKN', 12, 0, 0, 0, 0, 0, CAST(N'2018-05-31 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (54, N'XAX', N'DRB000000012', N'ITM-FOI', 35, 0, 0, 0, 0, 0, CAST(N'2018-05-31 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:51:01.520' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (55, N'XAX', N'DRB000000012', N'ITM-SAU', 25, 0, 0, 0, 0, 0, CAST(N'2018-05-31 00:00:00.000' AS DateTime), CAST(N'2018-05-31 15:51:01.520' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (56, N'BR00002', N'DRB000000013', N'ITM-CHK', 95, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.080' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (57, N'BR00002', N'DRB000000013', N'ITM-LIE', 65, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (58, N'BR00002', N'DRB000000013', N'ITM-ATS', 54, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (59, N'BR00002', N'DRB000000013', N'ITM-CKN', 25, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (60, N'BR00002', N'DRB000000013', N'ITM-FOI', 25, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (61, N'BR00002', N'DRB000000013', N'ITM-SAU', 41, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (62, N'BR00002', N'DRB000000013', N'ITM-TAN', 25, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (63, N'BR00002', N'DRB000000013', N'ITM-KAL', 45, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (64, N'BR00002', N'DRB000000013', N'ITM-SIL', 22, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (65, N'BR00002', N'DRB000000013', N'ITM-SBT', 12, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (66, N'BR00002', N'DRB000000013', N'ITM-SPT', 1, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (67, N'BR00002', N'DRB000000013', N'ITM-ULI', 25, 0, 0, 0, 0, 0, CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (68, N'XAX', N'DRB000000014', N'ITM-CHK', 50, 0, 0, 0, 0, 0, CAST(N'2018-06-28 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:37:27.787' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (69, N'XAX', N'DRB000000014', N'ITM-LIE', 42, 0, 0, 0, 0, 0, CAST(N'2018-06-28 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:37:27.787' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (70, N'XAX', N'DRB000000014', N'ITM-FOI', 50, 0, 0, 0, 0, 0, CAST(N'2018-06-28 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:37:27.787' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (71, N'BR00023', N'DRB000000015', N'ITM-CHK', 56, 0, 0, 0, 0, 0, CAST(N'2018-06-08 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:45:06.703' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (72, N'BR00023', N'DRB000000015', N'ITM-LIE', 53, 0, 0, 0, 0, 0, CAST(N'2018-06-08 00:00:00.000' AS DateTime), CAST(N'2018-05-31 16:45:06.703' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (73, N'RU392', N'DRB000000016', N'ITM-CHK', 89, 0, 0, 0, 0, 0, CAST(N'2018-05-31 00:00:00.000' AS DateTime), CAST(N'2018-05-31 17:04:39.983' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (74, N'RU392', N'DRB000000016', N'ITM-LIE', 88, 0, 0, 0, 0, 0, CAST(N'2018-05-31 00:00:00.000' AS DateTime), CAST(N'2018-05-31 17:04:39.983' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (75, N'BRC101', N'DRB000000017', N'ITM-CHK', 350, 0, 0, 0, 0, 0, CAST(N'2018-06-01 00:00:00.000' AS DateTime), CAST(N'2018-06-01 16:23:13.400' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (76, N'BRC101', N'DRB000000017', N'ITM-LIE', 200, 0, 0, 0, 0, 0, CAST(N'2018-06-01 00:00:00.000' AS DateTime), CAST(N'2018-06-01 16:23:13.400' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (77, N'BR00001', N'DRB000000018', N'ITM-CHK', 85, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (78, N'BR00001', N'DRB000000018', N'ITM-LIE', 40, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (79, N'BR00001', N'DRB000000018', N'ITM-ATS', 35, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (80, N'BR00001', N'DRB000000018', N'ITM-CKN', 20, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (81, N'BR00001', N'DRB000000018', N'ITM-FOI', 5, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (82, N'BR00001', N'DRB000000018', N'ITM-SAU', 2, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (83, N'BR00001', N'DRB000000018', N'ITM-TAN', 3, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (84, N'BR00001', N'DRB000000018', N'ITM-KAL', 4, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.513' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (85, N'BR00001', N'DRB000000018', N'ITM-SIL', 5, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.513' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (86, N'BR00001', N'DRB000000018', N'ITM-SBT', 1, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.513' AS DateTime))
INSERT [TRANSACTION].[Branches] ([ID], [branchCode], [referenceNum], [itemCode], [Stock_In], [Stock_Out], [Adj_In], [Adj_Out], [Trans_In], [Trans_Out], [dateSpecify], [dateTrans]) VALUES (87, N'BR00001', N'DRB000000018', N'ITM-SPT', 23, 0, 0, 0, 0, 0, CAST(N'2018-06-02 00:00:00.000' AS DateTime), CAST(N'2018-06-02 08:36:18.513' AS DateTime))
SET IDENTITY_INSERT [TRANSACTION].[Branches] OFF
SET IDENTITY_INSERT [TRANSACTION].[Deliveries_Hdr] ON 

INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (29, N'BRC101', N'DRB000000001', CAST(N'2018-05-30 00:00:00.000' AS DateTime), N'Testing again and again', CAST(N'2018-05-31 10:42:49.997' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (30, N'BTX001', N'DRB000000002', CAST(N'2018-06-01 00:00:00.000' AS DateTime), N'testing lang eto.', CAST(N'2018-05-31 11:09:58.750' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (36, N'BTX001', N'DRB000000004', CAST(N'2018-06-01 00:00:00.000' AS DateTime), N'testing lang eto.', CAST(N'2018-05-31 11:11:23.847' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (37, N'BRC101', N'DRB000000005', CAST(N'2018-06-15 00:00:00.000' AS DateTime), N'oksgf', CAST(N'2018-05-31 11:16:45.987' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (38, N'BRC101', N'DRB000000006', CAST(N'2018-05-25 00:00:00.000' AS DateTime), N'dwadwa', CAST(N'2018-05-31 11:32:39.557' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (48, N'X3101', N'DRB000000008', CAST(N'2018-06-12 00:00:00.000' AS DateTime), N'Another testing only..', CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (49, N'XXX1', N'DRB000000009', CAST(N'2018-06-29 00:00:00.000' AS DateTime), N'This remarks should display on Report.', CAST(N'2018-05-31 15:01:57.487' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (50, N'XAX', N'DRB000000010', CAST(N'2018-05-30 00:00:00.000' AS DateTime), N'dawd', CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (51, N'NBRAN1', N'DRB000000011', CAST(N'2018-05-25 00:00:00.000' AS DateTime), N'dasfda', CAST(N'2018-05-31 15:46:51.963' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (52, N'XAX', N'DRB000000012', CAST(N'2018-05-31 00:00:00.000' AS DateTime), N'dawd', CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (53, N'BR00002', N'DRB000000013', CAST(N'2018-06-13 00:00:00.000' AS DateTime), N'tESTING AGAIN and again and again', CAST(N'2018-05-31 16:14:58.080' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (54, N'XAX', N'DRB000000014', CAST(N'2018-06-28 00:00:00.000' AS DateTime), N'wadwa', CAST(N'2018-05-31 16:37:27.783' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (55, N'BR00023', N'DRB000000015', CAST(N'2018-06-08 00:00:00.000' AS DateTime), N'dawdwa', CAST(N'2018-05-31 16:45:06.703' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (56, N'RU392', N'DRB000000016', CAST(N'2018-05-31 00:00:00.000' AS DateTime), N'dawd', CAST(N'2018-05-31 17:04:39.983' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (57, N'BRC101', N'DRB000000017', CAST(N'2018-06-01 00:00:00.000' AS DateTime), N'Testing again.', CAST(N'2018-06-01 16:23:13.400' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Hdr] ([ID], [branchCode], [deliveryNum], [deliveryDate], [remarks], [DI]) VALUES (58, N'BR00001', N'DRB000000018', CAST(N'2018-06-02 00:00:00.000' AS DateTime), N'Week 1', CAST(N'2018-06-02 08:36:18.510' AS DateTime))
SET IDENTITY_INSERT [TRANSACTION].[Deliveries_Hdr] OFF
SET IDENTITY_INSERT [TRANSACTION].[Deliveries_Line] ON 

INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (1, N'DRB000000001', N'ITM-CHK', 50, CAST(N'2018-05-31 10:42:49.997' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (2, N'DRB000000001', N'ITM-LIE', 20, CAST(N'2018-05-31 10:42:49.997' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (3, N'DRB000000001', N'ITM-FOI', 1, CAST(N'2018-05-31 10:42:50.000' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (4, N'DRB000000001', N'ITM-SAU', 1000, CAST(N'2018-05-31 10:42:50.000' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (5, N'DRB000000001', N'ITM-SPT', 500, CAST(N'2018-05-31 10:42:50.000' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (6, N'DRB000000001', N'ITM-ULI', 3, CAST(N'2018-05-31 10:42:50.000' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (7, N'DRB000000002', N'ITM-CHK', 8, CAST(N'2018-05-31 11:09:58.750' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (8, N'DRB000000002', N'ITM-LIE', 7, CAST(N'2018-05-31 11:09:58.750' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (9, N'DRB000000002', N'ITM-ATS', 8, CAST(N'2018-05-31 11:09:58.753' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (10, N'DRB000000002', N'ITM-CKN', 50, CAST(N'2018-05-31 11:09:58.753' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (11, N'DRB000000002', N'ITM-SIL', 8, CAST(N'2018-05-31 11:09:58.753' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (17, N'DRB000000004', N'ITM-CHK', 8, CAST(N'2018-05-31 11:11:23.847' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (18, N'DRB000000004', N'ITM-LIE', 7, CAST(N'2018-05-31 11:11:23.847' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (19, N'DRB000000004', N'ITM-ATS', 8, CAST(N'2018-05-31 11:11:23.847' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (20, N'DRB000000004', N'ITM-CKN', 50, CAST(N'2018-05-31 11:11:23.850' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (21, N'DRB000000004', N'ITM-SIL', 8, CAST(N'2018-05-31 11:11:23.850' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (22, N'DRB000000005', N'ITM-CHK', 50, CAST(N'2018-05-31 11:16:45.987' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (23, N'DRB000000005', N'ITM-LIE', 5, CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (24, N'DRB000000005', N'ITM-ATS', 9, CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (25, N'DRB000000005', N'ITM-CKN', 10, CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (26, N'DRB000000005', N'ITM-SAU', 50, CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (27, N'DRB000000005', N'ITM-SIL', 2, CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (28, N'DRB000000005', N'ITM-SBT', 35, CAST(N'2018-05-31 11:16:45.990' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (29, N'DRB000000006', N'ITM-CHK', 500, CAST(N'2018-05-31 11:32:39.557' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (30, N'DRB000000006', N'ITM-LIE', 200, CAST(N'2018-05-31 11:32:39.557' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (31, N'DRB000000006', N'ITM-ATS', 20, CAST(N'2018-05-31 11:32:39.560' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (32, N'DRB000000006', N'ITM-CKN', 80, CAST(N'2018-05-31 11:32:39.560' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (33, N'DRB000000006', N'ITM-TAN', 25, CAST(N'2018-05-31 11:32:39.560' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (43, N'DRB000000008', N'ITM-CHK', 60, CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (44, N'DRB000000008', N'ITM-LIE', 30, CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (45, N'DRB000000008', N'ITM-FOI', 20, CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (46, N'DRB000000008', N'ITM-SAU', 10, CAST(N'2018-05-31 14:17:52.983' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (47, N'DRB000000009', N'ITM-CHK', 50, CAST(N'2018-05-31 15:01:57.487' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (48, N'DRB000000009', N'ITM-LIE', 45, CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (49, N'DRB000000009', N'ITM-ATS', 40, CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (50, N'DRB000000009', N'ITM-CKN', 35, CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (51, N'DRB000000009', N'ITM-FOI', 30, CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (52, N'DRB000000009', N'ITM-SAU', 25, CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (53, N'DRB000000009', N'ITM-TAN', 20, CAST(N'2018-05-31 15:01:57.490' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (54, N'DRB000000009', N'ITM-KAL', 15, CAST(N'2018-05-31 15:01:57.493' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (55, N'DRB000000009', N'ITM-SIL', 10, CAST(N'2018-05-31 15:01:57.493' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (56, N'DRB000000009', N'ITM-SBT', 5, CAST(N'2018-05-31 15:01:57.493' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (57, N'DRB000000009', N'ITM-SPT', 4, CAST(N'2018-05-31 15:01:57.493' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (58, N'DRB000000009', N'ITM-ULI', 3, CAST(N'2018-05-31 15:01:57.497' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (59, N'DRB000000010', N'ITM-CHK', 50, CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (60, N'DRB000000010', N'ITM-LIE', 20, CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (61, N'DRB000000010', N'ITM-ATS', 14, CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (62, N'DRB000000010', N'ITM-CKN', 45, CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (63, N'DRB000000010', N'ITM-FOI', 53, CAST(N'2018-05-31 15:45:16.090' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (64, N'DRB000000011', N'ITM-CHK', 20, CAST(N'2018-05-31 15:46:51.963' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (65, N'DRB000000011', N'ITM-LIE', 52, CAST(N'2018-05-31 15:46:51.963' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (66, N'DRB000000012', N'ITM-CHK', 85, CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (67, N'DRB000000012', N'ITM-LIE', 62, CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (68, N'DRB000000012', N'ITM-ATS', 20, CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (69, N'DRB000000012', N'ITM-CKN', 12, CAST(N'2018-05-31 15:51:01.517' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (70, N'DRB000000012', N'ITM-FOI', 35, CAST(N'2018-05-31 15:51:01.520' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (71, N'DRB000000012', N'ITM-SAU', 25, CAST(N'2018-05-31 15:51:01.520' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (72, N'DRB000000013', N'ITM-CHK', 95, CAST(N'2018-05-31 16:14:58.080' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (73, N'DRB000000013', N'ITM-LIE', 65, CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (74, N'DRB000000013', N'ITM-ATS', 54, CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (75, N'DRB000000013', N'ITM-CKN', 25, CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (76, N'DRB000000013', N'ITM-FOI', 25, CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (77, N'DRB000000013', N'ITM-SAU', 41, CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (78, N'DRB000000013', N'ITM-TAN', 25, CAST(N'2018-05-31 16:14:58.083' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (79, N'DRB000000013', N'ITM-KAL', 45, CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (80, N'DRB000000013', N'ITM-SIL', 22, CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (81, N'DRB000000013', N'ITM-SBT', 12, CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (82, N'DRB000000013', N'ITM-SPT', 1, CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (83, N'DRB000000013', N'ITM-ULI', 25, CAST(N'2018-05-31 16:14:58.087' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (84, N'DRB000000014', N'ITM-CHK', 50, CAST(N'2018-05-31 16:37:27.783' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (85, N'DRB000000014', N'ITM-LIE', 42, CAST(N'2018-05-31 16:37:27.787' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (86, N'DRB000000014', N'ITM-FOI', 50, CAST(N'2018-05-31 16:37:27.787' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (87, N'DRB000000015', N'ITM-CHK', 56, CAST(N'2018-05-31 16:45:06.703' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (88, N'DRB000000015', N'ITM-LIE', 53, CAST(N'2018-05-31 16:45:06.703' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (89, N'DRB000000016', N'ITM-CHK', 89, CAST(N'2018-05-31 17:04:39.983' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (90, N'DRB000000016', N'ITM-LIE', 88, CAST(N'2018-05-31 17:04:39.983' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (91, N'DRB000000017', N'ITM-CHK', 350, CAST(N'2018-06-01 16:23:13.400' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (92, N'DRB000000017', N'ITM-LIE', 200, CAST(N'2018-06-01 16:23:13.400' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (93, N'DRB000000018', N'ITM-CHK', 85, CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (94, N'DRB000000018', N'ITM-LIE', 40, CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (95, N'DRB000000018', N'ITM-ATS', 35, CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (96, N'DRB000000018', N'ITM-CKN', 20, CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (97, N'DRB000000018', N'ITM-FOI', 5, CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (98, N'DRB000000018', N'ITM-SAU', 2, CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (99, N'DRB000000018', N'ITM-TAN', 3, CAST(N'2018-06-02 08:36:18.510' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (100, N'DRB000000018', N'ITM-KAL', 4, CAST(N'2018-06-02 08:36:18.513' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (101, N'DRB000000018', N'ITM-SIL', 5, CAST(N'2018-06-02 08:36:18.513' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (102, N'DRB000000018', N'ITM-SBT', 1, CAST(N'2018-06-02 08:36:18.513' AS DateTime))
INSERT [TRANSACTION].[Deliveries_Line] ([ID], [deliveryNum], [itemCode], [quantity], [DI]) VALUES (103, N'DRB000000018', N'ITM-SPT', 23, CAST(N'2018-06-02 08:36:18.513' AS DateTime))
SET IDENTITY_INSERT [TRANSACTION].[Deliveries_Line] OFF
SET IDENTITY_INSERT [UTIL].[Branch_Area] ON 

INSERT [UTIL].[Branch_Area] ([AreaID], [AreaName], [position], [IsActive]) VALUES (1, N'ZAPOTE 1', 10, 1)
INSERT [UTIL].[Branch_Area] ([AreaID], [AreaName], [position], [IsActive]) VALUES (2, N'CAVITE AREA E', 1, 1)
INSERT [UTIL].[Branch_Area] ([AreaID], [AreaName], [position], [IsActive]) VALUES (3, N'CAVITE AREA G', 2, 1)
INSERT [UTIL].[Branch_Area] ([AreaID], [AreaName], [position], [IsActive]) VALUES (4, N'BACLARAN', 3, 1)
INSERT [UTIL].[Branch_Area] ([AreaID], [AreaName], [position], [IsActive]) VALUES (5, N'IMUS BAYAN', 4, 1)
SET IDENTITY_INSERT [UTIL].[Branch_Area] OFF
SET IDENTITY_INSERT [UTIL].[Branch_Incharge_RF] ON 

INSERT [UTIL].[Branch_Incharge_RF] ([branchInchargeID], [branchInchargeName], [isActive]) VALUES (1, N'', 1)
INSERT [UTIL].[Branch_Incharge_RF] ([branchInchargeID], [branchInchargeName], [isActive]) VALUES (2, N'RAMIR MISTA', 1)
INSERT [UTIL].[Branch_Incharge_RF] ([branchInchargeID], [branchInchargeName], [isActive]) VALUES (3, N'BUGOY PREPET', 1)
INSERT [UTIL].[Branch_Incharge_RF] ([branchInchargeID], [branchInchargeName], [isActive]) VALUES (4, N'LANDO MAGBRA', 1)
INSERT [UTIL].[Branch_Incharge_RF] ([branchInchargeID], [branchInchargeName], [isActive]) VALUES (5, N'TROY PUNA', 1)
SET IDENTITY_INSERT [UTIL].[Branch_Incharge_RF] OFF
INSERT [UTIL].[Days_RF] ([day]) VALUES (1)
INSERT [UTIL].[Days_RF] ([day]) VALUES (2)
INSERT [UTIL].[Days_RF] ([day]) VALUES (3)
INSERT [UTIL].[Days_RF] ([day]) VALUES (4)
INSERT [UTIL].[Days_RF] ([day]) VALUES (5)
INSERT [UTIL].[Days_RF] ([day]) VALUES (6)
INSERT [UTIL].[Days_RF] ([day]) VALUES (7)
INSERT [UTIL].[Days_RF] ([day]) VALUES (8)
INSERT [UTIL].[Days_RF] ([day]) VALUES (9)
INSERT [UTIL].[Days_RF] ([day]) VALUES (10)
INSERT [UTIL].[Days_RF] ([day]) VALUES (11)
INSERT [UTIL].[Days_RF] ([day]) VALUES (12)
INSERT [UTIL].[Days_RF] ([day]) VALUES (13)
INSERT [UTIL].[Days_RF] ([day]) VALUES (14)
INSERT [UTIL].[Days_RF] ([day]) VALUES (15)
INSERT [UTIL].[Days_RF] ([day]) VALUES (16)
INSERT [UTIL].[Days_RF] ([day]) VALUES (17)
INSERT [UTIL].[Days_RF] ([day]) VALUES (18)
INSERT [UTIL].[Days_RF] ([day]) VALUES (19)
INSERT [UTIL].[Days_RF] ([day]) VALUES (20)
INSERT [UTIL].[Days_RF] ([day]) VALUES (21)
INSERT [UTIL].[Days_RF] ([day]) VALUES (22)
INSERT [UTIL].[Days_RF] ([day]) VALUES (23)
INSERT [UTIL].[Days_RF] ([day]) VALUES (24)
INSERT [UTIL].[Days_RF] ([day]) VALUES (25)
INSERT [UTIL].[Days_RF] ([day]) VALUES (26)
INSERT [UTIL].[Days_RF] ([day]) VALUES (27)
INSERT [UTIL].[Days_RF] ([day]) VALUES (28)
INSERT [UTIL].[Days_RF] ([day]) VALUES (29)
INSERT [UTIL].[Days_RF] ([day]) VALUES (30)
INSERT [UTIL].[Days_RF] ([day]) VALUES (31)
SET IDENTITY_INSERT [UTIL].[DM_Request_Status_RF] ON 

INSERT [UTIL].[DM_Request_Status_RF] ([ID], [RequestStatus], [RequestDescription], [Type]) VALUES (1, N'A', N'Approved', 1)
INSERT [UTIL].[DM_Request_Status_RF] ([ID], [RequestStatus], [RequestDescription], [Type]) VALUES (2, N'F', N'For Approval', 0)
INSERT [UTIL].[DM_Request_Status_RF] ([ID], [RequestStatus], [RequestDescription], [Type]) VALUES (3, N'P', N'Pending', 1)
INSERT [UTIL].[DM_Request_Status_RF] ([ID], [RequestStatus], [RequestDescription], [Type]) VALUES (4, N'R', N'Reject', 1)
SET IDENTITY_INSERT [UTIL].[DM_Request_Status_RF] OFF
SET IDENTITY_INSERT [UTIL].[Item_Categories_RF] ON 

INSERT [UTIL].[Item_Categories_RF] ([itemCategoryID], [itemCategoryCode], [itemCategoryName]) VALUES (3, N'IO', N'Inventoriable Only')
INSERT [UTIL].[Item_Categories_RF] ([itemCategoryID], [itemCategoryCode], [itemCategoryName]) VALUES (2, N'IS', N'Inventoriable - Selling')
SET IDENTITY_INSERT [UTIL].[Item_Categories_RF] OFF
SET IDENTITY_INSERT [UTIL].[Item_Group_RF] ON 

INSERT [UTIL].[Item_Group_RF] ([GroupID], [ItemGroupCode], [groupName]) VALUES (1, N'RI', N'Regular Item')
INSERT [UTIL].[Item_Group_RF] ([GroupID], [ItemGroupCode], [groupName]) VALUES (2, N'UI', N'Utility Item')
SET IDENTITY_INSERT [UTIL].[Item_Group_RF] OFF
SET IDENTITY_INSERT [UTIL].[Machine_Equipment_RF] ON 

INSERT [UTIL].[Machine_Equipment_RF] ([MachEquipID], [MachEquipCode], [MachEquipName], [MachEquipType]) VALUES (2, N'E01', N'WALL FAN', N'E')
INSERT [UTIL].[Machine_Equipment_RF] ([MachEquipID], [MachEquipCode], [MachEquipName], [MachEquipType]) VALUES (3, N'E02', N'REFRIGERATOR', N'E')
INSERT [UTIL].[Machine_Equipment_RF] ([MachEquipID], [MachEquipCode], [MachEquipName], [MachEquipType]) VALUES (4, N'E03', N'CHOPPING BOARD', N'E')
INSERT [UTIL].[Machine_Equipment_RF] ([MachEquipID], [MachEquipCode], [MachEquipName], [MachEquipType]) VALUES (1, N'M01', N'RATOR', N'M')
INSERT [UTIL].[Machine_Equipment_RF] ([MachEquipID], [MachEquipCode], [MachEquipName], [MachEquipType]) VALUES (5, N'M02', N'GRILLING MACHINE', N'M')
SET IDENTITY_INSERT [UTIL].[Machine_Equipment_RF] OFF
INSERT [UTIL].[Mode_Payment_RF] ([paymentModeCode], [paymentModeName], [arr]) VALUES (N'AN', N'ANNUALY / YEARLY', N'D')
INSERT [UTIL].[Mode_Payment_RF] ([paymentModeCode], [paymentModeName], [arr]) VALUES (N'MO', N'MONTHLY', N'A')
INSERT [UTIL].[Mode_Payment_RF] ([paymentModeCode], [paymentModeName], [arr]) VALUES (N'QU', N'QUARTERLY', N'B')
INSERT [UTIL].[Mode_Payment_RF] ([paymentModeCode], [paymentModeName], [arr]) VALUES (N'SA', N'SEMI-ANNUAL', N'C')
SET IDENTITY_INSERT [UTIL].[Reports_RF] ON 

INSERT [UTIL].[Reports_RF] ([reportID], [reportDescription], [reportFileName], [reportGroup]) VALUES (1, N'Summary Detail - All', N'repDebitMemoTotalSummary_Details', N'DMS')
INSERT [UTIL].[Reports_RF] ([reportID], [reportDescription], [reportFileName], [reportGroup]) VALUES (2, N'Summary List - All', N'repDebitMemoTotalSummary_List', N'DMS')
INSERT [UTIL].[Reports_RF] ([reportID], [reportDescription], [reportFileName], [reportGroup]) VALUES (3, N'Branch Summary Details', N'repDebitMemoTotalSummary_Details_Branch', N'DMS')
INSERT [UTIL].[Reports_RF] ([reportID], [reportDescription], [reportFileName], [reportGroup]) VALUES (4, N'Branch Summary Lists', N'repDebitMemoTotalSummary_List_Branch', N'DMS')
INSERT [UTIL].[Reports_RF] ([reportID], [reportDescription], [reportFileName], [reportGroup]) VALUES (6, N'Supervisor Summary Details', N'repDebitMemoTotalSummary_Details_Supervisor', N'DMS')
INSERT [UTIL].[Reports_RF] ([reportID], [reportDescription], [reportFileName], [reportGroup]) VALUES (7, N'Supervisor Summary Lists', N'repDebitMemoTotalSummary_List_Supervisor', N'DMS')
INSERT [UTIL].[Reports_RF] ([reportID], [reportDescription], [reportFileName], [reportGroup]) VALUES (8, N'Dispatch Summary Lists', N'repDispatchDM', N'DMS')
INSERT [UTIL].[Reports_RF] ([reportID], [reportDescription], [reportFileName], [reportGroup]) VALUES (1008, N'Request Item Status', N'repDMRequestMonitoring', N'DMS')
SET IDENTITY_INSERT [UTIL].[Reports_RF] OFF
INSERT [UTIL].[Status_RF] ([statusCode], [statusName]) VALUES (N'A', N'ACTIVE')
INSERT [UTIL].[Status_RF] ([statusCode], [statusName]) VALUES (N'I', N'IN-ACTIVE')
SET IDENTITY_INSERT [UTIL].[Supervisor_RF] ON 

INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (1, N'BOLONIA, MARCELO', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (2, N'BIBAT, EDWIN', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (3, N'OCON, LEONARDO', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (4, N'TARAY, GERRY', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (5, N'HANGAD, PABLITO', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (6, N'BALANE, FRANCIS', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (7, N'POLVER, ALBERT', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (8, N'MAHINAY, ROQUE', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (9, N'EDERANGO, EDDIE', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (10, N'CHATTO, JERRY', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (11, N'ELPIDO JUSTO III', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (12, N'UNABIA, ROLLY', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (13, N'TAMBIS, ARIEL', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (14, N'ASUNCION, FLORANTE', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (15, N'CARLOS, JAKE MAR', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (16, N'SUMABONG, JOSEPH', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
INSERT [UTIL].[Supervisor_RF] ([supervisorID], [supervisorName], [isActive], [DI], [DU], [userCode]) VALUES (17, N'NARAG, JERAHMEEL', 1, CAST(N'2018-06-18 09:52:20.937' AS DateTime), CAST(N'2018-06-18 09:52:20.937' AS DateTime), NULL)
SET IDENTITY_INSERT [UTIL].[Supervisor_RF] OFF
SET IDENTITY_INSERT [UTIL].[UnitOfMeasurement_RF] ON 

INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (1, N'PC', N'PIECES', NULL, NULL, NULL)
INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (2, N'KL', N'KILO', NULL, NULL, NULL)
INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (3, N'SCK', N'SACK', NULL, NULL, NULL)
INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (4, N'BG', N'BAG', NULL, NULL, NULL)
INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (5, N'UN', N'UNIT', NULL, NULL, NULL)
INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (6, N'DOZ', N'DOZEN', NULL, CAST(N'2018-06-19 16:28:02.320' AS DateTime), N'1')
INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (7, N'HLF', N'HALF', NULL, NULL, NULL)
INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (8, N'OZ', N'OUNCE', NULL, NULL, NULL)
INSERT [UTIL].[UnitOfMeasurement_RF] ([uomID], [uomCode], [uomDescription], [DI], [DU], [userCode]) VALUES (9, N'NA', N'N/A', CAST(N'2018-06-19 16:54:37.667' AS DateTime), CAST(N'2018-06-19 16:54:37.667' AS DateTime), N'1')
SET IDENTITY_INSERT [UTIL].[UnitOfMeasurement_RF] OFF
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (1, N'Master File', N'#', 0, N'TOP', N'A1', 1, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (2, N'Deliveries', N'#', 0, N'TOP', N'A2', 1, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (3, N'Inventories', N'#', 0, N'TOP', N'A3', 1, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (4, N'Sales', N'#', 0, N'TOP', N'A4', 1, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (5, N'Accounting', N'#', 0, N'TOP', N'A5', 1, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (6, N'Reports', N'#', 0, N'TOP', N'A6', 1, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (7, N'Maintenance', N'#', 0, N'TOP', N'A7', 1, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (8, N'Branch', N'BranchMaster.aspx', 1, N'MID', N'A3', 0, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (9, N'Item', N'Item.aspx', 1, N'MID', N'A1', 0, 1)
INSERT [xSys].[Menu_MF] ([menuID], [menuText], [url], [parentMenuID], [position], [arr], [flgChild], [active]) VALUES (10, N'Branch Delivery', N'BranchItemDelivery.aspx', 2, N'MID', N'A1', 0, 1)
SET IDENTITY_INSERT [xSys].[SeriesNumber_RF] ON 

INSERT [xSys].[SeriesNumber_RF] ([id], [PrefixCode], [PrefixAppend], [Description], [Series], [IsNumberOnly]) VALUES (2, N'DM', N'DM', N'Debit Memo', 0, 0)
INSERT [xSys].[SeriesNumber_RF] ([id], [PrefixCode], [PrefixAppend], [Description], [Series], [IsNumberOnly]) VALUES (1, N'DRB', N'DRB', N'Delivery Receipt Branch', 18, 0)
SET IDENTITY_INSERT [xSys].[SeriesNumber_RF] OFF
SET IDENTITY_INSERT [xSys].[User_MF] ON 

INSERT [xSys].[User_MF] ([ID], [UserCode], [UserName], [Password], [Account_Type_Code], [FlgStatus], [LastLog], [DMTAccess], [DI]) VALUES (1, N'1', N'Russel Vasquez', N'p@ssw0rd', N'A', 1, CAST(N'2018-06-07 14:34:40.567' AS DateTime), 1, CAST(N'2018-06-07 14:34:40.567' AS DateTime))
INSERT [xSys].[User_MF] ([ID], [UserCode], [UserName], [Password], [Account_Type_Code], [FlgStatus], [LastLog], [DMTAccess], [DI]) VALUES (2, N'2', N'User Testing', N'2', N'O', 1, CAST(N'2018-06-07 14:35:02.980' AS DateTime), 1, CAST(N'2018-06-07 14:35:02.980' AS DateTime))
INSERT [xSys].[User_MF] ([ID], [UserCode], [UserName], [Password], [Account_Type_Code], [FlgStatus], [LastLog], [DMTAccess], [DI]) VALUES (3, N'Malou', N'MALOU', N'abcd123', N'O', 1, CAST(N'2018-06-11 14:02:52.440' AS DateTime), 0, CAST(N'2018-06-11 14:02:52.440' AS DateTime))
INSERT [xSys].[User_MF] ([ID], [UserCode], [UserName], [Password], [Account_Type_Code], [FlgStatus], [LastLog], [DMTAccess], [DI]) VALUES (4, N'mgmu', N'Mary Grace Unabia', N'abc123', N'A', 1, CAST(N'2018-06-11 14:03:31.860' AS DateTime), 0, CAST(N'2018-06-11 14:03:31.860' AS DateTime))
SET IDENTITY_INSERT [xSys].[User_MF] OFF
ALTER TABLE [INVENTORY].[Branches] ADD  CONSTRAINT [DF_Table_1_stockOpening]  DEFAULT ((0)) FOR [tStockBeginning]
GO
ALTER TABLE [INVENTORY].[Branches] ADD  CONSTRAINT [DF_Table_1_stockIn]  DEFAULT ((0)) FOR [tStockIn]
GO
ALTER TABLE [INVENTORY].[Branches] ADD  CONSTRAINT [DF_Table_1_stockOut]  DEFAULT ((0)) FOR [tStockOut]
GO
ALTER TABLE [INVENTORY].[Branches] ADD  CONSTRAINT [DF_Table_1_stockAdjustmentIn]  DEFAULT ((0)) FOR [tStockAdjustmentIn]
GO
ALTER TABLE [INVENTORY].[Branches] ADD  CONSTRAINT [DF_Table_1_stockAdjustmentOut]  DEFAULT ((0)) FOR [tStockAdjustmentOut]
GO
ALTER TABLE [INVENTORY].[Branches] ADD  CONSTRAINT [DF_Table_1_stockEnding]  DEFAULT ((0)) FOR [tStockEnding]
GO
ALTER TABLE [INVENTORY].[Branches] ADD  CONSTRAINT [DF_Table_1_stockBalance]  DEFAULT ((0)) FOR [tStockBalance]
GO
ALTER TABLE [INVENTORY].[Branches] ADD  CONSTRAINT [DF_Branches_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [MASTER].[Branches_Machine_Equipment] ADD  CONSTRAINT [DF_Branches_Machine_Equipment_isActive]  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [MASTER].[Branches_Machine_Equipment] ADD  CONSTRAINT [DF_Branches_Machine_Equipment_DI]  DEFAULT (getdate()) FOR [DI]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DebitMemoRequest_Header_TF_DateRequest]  DEFAULT (getdate()) FOR [DateRequest]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DebitMemoRequest_Header_TF_IsCompleted]  DEFAULT ((0)) FOR [IsCompleted]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DebitMemoRequest_Header_TF_IsCancel]  DEFAULT ((0)) FOR [IsCancel]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DebitMemoRequest_Header_TF_IsPrinted]  DEFAULT ((0)) FOR [IsPrint]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DebitMemoRequest_Header_TF_IsOpen]  DEFAULT ((0)) FOR [IsOpen]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DM_Request_Header_IsPosted]  DEFAULT ((0)) FOR [IsPosted]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DM_Request_Header_IsDispatch]  DEFAULT ((0)) FOR [IsDispatch]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DM_Request_Header_TotalAmountPrice]  DEFAULT ((0)) FOR [TotalAmountPrice]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DebitMemoRequest_Header_TF_DU]  DEFAULT (getdate()) FOR [DU]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Header] ADD  CONSTRAINT [DF_DebitMemoRequest_Header_TF_DI]  DEFAULT (getdate()) FOR [DI]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Line] ADD  CONSTRAINT [DF_DM_Request_Line_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Line] ADD  CONSTRAINT [DF_DebitMemoRequest_TF_RequestStatus]  DEFAULT (N'F') FOR [RequestStatus]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Line] ADD  CONSTRAINT [DF_DebitMemoRequest_TF_DI]  DEFAULT (getdate()) FOR [DI]
GO
ALTER TABLE [TRANSACTION].[DM_Request_Line] ADD  CONSTRAINT [DF_DebitMemoRequest_TF_IsAttachment]  DEFAULT ((0)) FOR [IsAttachment]
GO
ALTER TABLE [TRANSACTION].[Items] ADD  CONSTRAINT [DF_Items_quantity]  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [TRANSACTION].[Items] ADD  CONSTRAINT [DF_Items_dateTrans]  DEFAULT (getdate()) FOR [dateTrans]
GO
ALTER TABLE [xSys].[DM_Audit_logs] ADD  CONSTRAINT [DF_DM_Audit_logs_di]  DEFAULT (getdate()) FOR [di]
GO
ALTER TABLE [MASTER].[Branches_Machine_Equipment]  WITH CHECK ADD  CONSTRAINT [FK_Branches_Machine_Equipment_Branches] FOREIGN KEY([branchCode])
REFERENCES [MASTER].[Branches] ([branchCode])
GO
ALTER TABLE [MASTER].[Branches_Machine_Equipment] CHECK CONSTRAINT [FK_Branches_Machine_Equipment_Branches]
GO
/****** Object:  StoredProcedure [MASTER].[spDELETE_BRANCH_MACHINE_EQUIPMENT]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: UPDATE/DELETE BRANCH MACHINE AND EQUIPMENT

--DATE: 05/24/2018
--VERSION: 1

CREATE PROC [MASTER].[spDELETE_BRANCH_MACHINE_EQUIPMENT]
@ID int,
@DELETED_REMARKS nvarchar(150)
AS

BEGIN

	UPDATE [MASTER].[Branches_Machine_Equipment]
	SET 
		isDeleted = 1, deletedRemarks = @DELETED_REMARKS, deletedDate = getdate()
	WHERE
		ID=@ID

END
GO
/****** Object:  StoredProcedure [MASTER].[spGET_BRANCH_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: DISPLAY BRANCH DATA LIST

--DATE: 05/15/2018
--VERSION: 1

CREATE PROC [MASTER].[spGET_BRANCH_LIST]
AS
BEGIN

	SELECT *, A.isActive as Branch_IsActive
	FROM
	[MASTER].[Branches] A
	LEFT JOIN [UTIL].Branch_Area B
	ON A.areaID = B.AreaID
	LEFT JOIN [UTIL].Supervisor_RF C
	ON A.supervisorID = C.SupervisorID
	LEFT JOIN [UTIL].Mode_Payment_RF D
	ON A.modePaymentCode = D.paymentModeCode
	LEFT JOIN [UTIL].[Branch_Incharge_RF] E
	ON A.branchInchargeID = E.branchInchargeID
	ORDER BY A.branchName



	
END
GO
/****** Object:  StoredProcedure [MASTER].[spGET_BRANCH_MACHINE_EQUIPMENT_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: DISPLAY BRANCH MACHINE EQUIPMENT ISSUED LIST

--DATE: 05/21/2018
--VERSION: 1

CREATE PROC [MASTER].[spGET_BRANCH_MACHINE_EQUIPMENT_LIST]
AS
BEGIN

	SELECT *, Convert(date,A.dateIssue,101) as dateIssueFormat
	FROM [MASTER].[Branches_Machine_Equipment] A
	INNER JOIN 
	[UTIL].[Machine_Equipment_RF] B 
	ON A.machEquipCode = B.MachEquipCode
	WHERE A.isDeleted = 0
	ORDER BY dateIssue DESC

	
END
GO
/****** Object:  StoredProcedure [MASTER].[spGET_DM_ITEM_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/29/2018>
-- Description:	<GET USER_VALIDATION>
-- =============================================
CREATE PROCEDURE [MASTER].[spGET_DM_ITEM_LIST]
AS
BEGIN
	
	SELECT * FROM
	[MASTER].[DM_Item_MF] A
	LEFT JOIN 
	[UTIL].[UnitOfMeasurement_RF] B
	ON A.UOM = B.uomCode
	LEFT JOIN
	[UTIL].[Item_Group_RF] C
	ON A.ItemGroupCode = C.ItemGroupCode

	
END


GO
/****** Object:  StoredProcedure [MASTER].[spGET_ITEMS_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: DISPLAY ITEM LIST

--DATE: 05/30/2018
--VERSION: 1

CREATE PROC [MASTER].[spGET_ITEMS_LIST]
AS
BEGIN

	SELECT *
	FROM [MASTER].[Items]
	ORDER BY ARR



	
END
GO
/****** Object:  StoredProcedure [MASTER].[spGET_PARTNERS_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: DISPLAY PARTNERS LIST

--DATE: 05/17/2018
--VERSION: 1

CREATE PROC [MASTER].[spGET_PARTNERS_LIST]
AS
BEGIN

SELECT *
FROM [MASTER].[Partners]



	
END
GO
/****** Object:  StoredProcedure [MASTER].[spINSERT_BRANCH]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: INSERT NEW BRANCH DATA

--DATE: 05/11/2018
--VERSION: 1

CREATE PROC [MASTER].[spINSERT_BRANCH]
@BRANCH_CODE nvarchar(10),
@BRANCH_NAME nvarchar(75),
@BRANCH_ADDRESS nvarchar(100),
@BRANCH_CONTACT_NUMBER nvarchar(50),
@BRANCH_INCHARGE_ID int,
@SUPERVISOR_ID int,
@PARTNER_CODE nvarchar(10),
@OPENING_DATE date,
@AREAID int,
@LESSOR_NAME nvarchar(70),
@MODE_PAYMENT_CODE nvarchar(2),
@PAYMENT_DAY int,
@REMARKS nvarchar(250)
AS
BEGIN

	INSERT INTO [MASTER].[Branches]
	(branchCode,branchName,branchAddress,branchContactNumbers,branchInchargeID,supervisorID,partnerCode,openingDate,areaID,
	 lessorName,modePaymentCode,paymentDay,remarks)
	VALUES
	(UPPER(@BRANCH_CODE),UPPER(@BRANCH_NAME),@BRANCH_ADDRESS,@BRANCH_CONTACT_NUMBER,@BRANCH_INCHARGE_ID,@SUPERVISOR_ID,
	@PARTNER_CODE,convert(date,@OPENING_DATE,101), @AREAID,
	UPPER(@LESSOR_NAME),@MODE_PAYMENT_CODE,@PAYMENT_DAY,@REMARKS)

	--INSERT DYNAMIC TO INVENTORY BRANCHES
	INSERT INTO [Inventory].Branches(branchCode,itemCode)
	SELECT UPPER(@BRANCH_CODE), itemCode 
	FROM Master.Items

END
GO
/****** Object:  StoredProcedure [MASTER].[spINSERT_BRANCH_MACHINE_EQUIPMENT]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: INSERT NEW BRANCH MACHINE AND EQUIPMENT

--DATE: 05/19/2018
--VERSION: 1

CREATE PROC [MASTER].[spINSERT_BRANCH_MACHINE_EQUIPMENT]
@BRANCH_CODE nvarchar(10),
@MACHEQUIP_CODE nvarchar(3),
@ADDITIONAL_DESCRIPTION nvarchar(75),
@SERIAL nvarchar(40),
@DATE_ISSUE date
AS

BEGIN

	INSERT INTO [MASTER].[Branches_Machine_Equipment]
	(branchCode,machEquipCode,addtDescription,serial,dateIssue)
	VALUES
	(UPPER(@BRANCH_CODE),@MACHEQUIP_CODE,UPPER(@ADDITIONAL_DESCRIPTION),@SERIAL,convert(date,@DATE_ISSUE,101))

END
GO
/****** Object:  StoredProcedure [MASTER].[spUPDATE_BRANCH]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: UPDATE BRANCH DATA

--DATE: 05/18/2018
--VERSION: 1

CREATE PROC [MASTER].[spUPDATE_BRANCH]
@BRANCH_CODE nvarchar(10),
@BRANCH_NAME nvarchar(75),
@BRANCH_ADDRESS nvarchar(100),
@BRANCH_CONTACT_NUMBER nvarchar(50),
@BRANCH_INCHARGE_ID int,
@SUPERVISOR_ID int,
@PARTNER_CODE nvarchar(10),
@OPENING_DATE date,
@AREAID int,
@LESSOR_NAME nvarchar(70),
@MODE_PAYMENT_CODE nvarchar(2),
@PAYMENT_DAY int,
@REMARKS nvarchar(250),
@IS_ACTIVE bit
AS
BEGIN

	UPDATE [MASTER].[Branches]
	SET
		branchName=@BRANCH_NAME, branchAddress=@BRANCH_ADDRESS, branchContactNumbers=@BRANCH_CONTACT_NUMBER,
		branchInchargeID=@BRANCH_INCHARGE_ID, supervisorID=@SUPERVISOR_ID, openingDate=@OPENING_DATE,
		partnerCode=@PARTNER_CODE,areaID=@AREAID,lessorName=@LESSOR_NAME,modePaymentCode=@MODE_PAYMENT_CODE,
		paymentDay=@PAYMENT_DAY, remarks=@REMARKS, isActive=@IS_ACTIVE
	WHERE
		branchCode=@BRANCH_CODE

END
GO
/****** Object:  StoredProcedure [MASTER].[spUPDATE_BRANCH_MACHINE_EQUIPMENT]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: UPDATE BRANCH MACHINE AND EQUIPMENT

--DATE: 05/22/2018
--VERSION: 1

CREATE PROC [MASTER].[spUPDATE_BRANCH_MACHINE_EQUIPMENT]
@ID int,
@MACHEQUIP_CODE nvarchar(3),
@ADDITIONAL_DESCRIPTION nvarchar(75),
@SERIAL nvarchar(40),
@DATE_ISSUE date
AS

BEGIN

	UPDATE [MASTER].[Branches_Machine_Equipment]
	SET machEquipCode = @MACHEQUIP_CODE,
		addtDescription = UPPER(@ADDITIONAL_DESCRIPTION),
		serial = @SERIAL,
		dateIssue = @DATE_ISSUE
	WHERE
		ID=@ID

END
GO
/****** Object:  StoredProcedure [TRANSACTION].[CHECK_EXIST_REQUEST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <7/2/2018>
-- Description:	<CHECK ALREADY EXIST>
-- =============================================

CREATE PROCEDURE [TRANSACTION].[CHECK_EXIST_REQUEST]
@DATEREQUEST datetime,
@SUPERVISORID int,
@BRANCHCODE nvarchar(70),
@TOTALAMOUNT float
AS
BEGIN

	SELECT CASE WHEN EXISTS(SELECT * FROM [TRANSACTION].[DM_Request_Header]
	WHERE DateRequest=Convert(date, @DATEREQUEST, 101) and SupervisorID=@SUPERVISORID and BranchCode=@BRANCHCODE and totalAmountPrice=@TOTALAMOUNT)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT)
	END

END

GO
/****** Object:  StoredProcedure [TRANSACTION].[GET_DM_BRANCH_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/23/2018>
-- Description:	<GET LIST BRANCHES>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[GET_DM_BRANCH_LIST] 
AS
BEGIN
	SELECT *, A.BranchName as SearchText FROM
	Master.Branches A
	order by a.BranchName
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_ALL_REQUEST_ITEM]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/08/2018>
-- Description:	<GET ALL REQUEST ITEMS ONLY>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_ALL_REQUEST_ITEM]
AS
BEGIN

	SELECT *
	FROM [TRANSACTION].[DM_Request_Header] A
	INNER JOIN [TRANSACTION].DM_Request_Line B
	ON A.DMRNum = B.DMRNum
	

END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_ATTACHMENT]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/28/2018>
-- Description:	<GET LIST OF ATTACHMENT>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_ATTACHMENT]
@DMRNUM nvarchar(15)
AS
BEGIN
	
	SELECT ItemDescription,OthersDetail, Attachment
	FROM [TRANSACTION].[DM_Request_Line]
	WHERE DMRNum=@DMRNUM and IsAttachment = 1
	
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_FOR_APPROVAL_REQUEST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/27/2018>
-- Description:	<GET FOR APPROVAL LIST ITEM>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_FOR_APPROVAL_REQUEST]
AS
BEGIN
	
	SELECT A.DMRNum, cONVERT(date, A.DateRequest) as DateRequest, B.BranchName, C.supervisorName, A.Requester_Notes
	FROM [TRANSACTION].DM_Request_Header A
	LEFT JOIN Master.Branches B
	ON A.BranchCode = B.BranchCode
	LEFT JOIN Util.Supervisor_RF C
	ON A.SupervisorID = C.supervisorID
	WHERE A.IsCompleted = 0
	ORDER BY A.DateRequest DESC
	
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_ITEM_FOR_APPROVAL]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/27/2018>
-- Description:	<GET FOR APPROVAL LIST ITEM>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_ITEM_FOR_APPROVAL]
@DMRNUM nvarchar(15)
AS
BEGIN
	
	SELECT ID,ItemDescription, Quantity, UnitPrice, Amount, othersDetail ,RequestStatus
	FROM [TRANSACTION].DM_Request_Line
	WHERE RequestStatus <> 'A' and RequestStatus <> 'R' and DMRNum = @DMRNUM
	
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_REQUEST_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/06/2018>
-- Description:	<GET ALL REQUEST COUNT>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_REQUEST_LIST]
AS
BEGIN

	SELECT *
	FROM [TRANSACTION].[DM_Request_Header]
	
	

END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_REQUEST_STATUS]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/27/2018>
-- Description:	<GET REQUEST STATUS>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_REQUEST_STATUS]
AS
BEGIN
	
	SELECT RequestStatus, RequestDescription
	FROM [UTIL].DM_Request_Status_RF
	WHERE TYPE = 1
	ORDER BY RequestStatus
	
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_USER_REQUESTED_ITEM_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/6/2018>
-- Description:	<GET LIST OF REQUESTED ITEM LIST OF DEBIT MEMO REQUEST>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_USER_REQUESTED_ITEM_LIST]
@DMRNUM nvarchar(15)
AS
BEGIN
	
	SELECT B.DMRNum, A.ItemDescription, A.Quantity,A.UnitPrice, A.Amount, A.OthersDetail,C.RequestDescription,A.RequestStatus
	FROM 
	[TRANSACTION].DM_Request_Line A
	INNER JOIN [TRANSACTION].DM_Request_Header B
	ON 
	A.DMRNum = B.DMRNum
	INNER JOIN [UTIL].DM_Request_Status_RF C
	ON A.RequestStatus = C.RequestStatus
	WHERE A.DMRNum = @DMRNUM
	ORDER BY A.ID
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_USER_REQUESTED_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/6/2018>
-- Description:	<GET LIST OF REQUESTED DEBIT MEMO REQUEST>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_USER_REQUESTED_LIST]
@USERCODE nvarchar(15)
AS
BEGIN
	
	SELECT A.DMRNum, Convert(date,A.DateRequest,101) as Date_Request, B.BranchName, A.IsPosted, A.IsCompleted, A.Approver_Notes
	FROM 
	[TRANSACTION].[DM_Request_Header] A
	INNER JOIN Master.Branches B
	ON A.BranchCode = B.BranchCode
	WHERE 
	A.UserCode = @USERCODE
	ORDER BY a.DateRequest DESC
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_USER_REQUESTED_LIST_FOR_DISPATCH]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/26/2018>
-- Description:	<GET LIST OF REQUESTED DEBIT MEMO REQUEST FOR DISPATCHING>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_USER_REQUESTED_LIST_FOR_DISPATCH]
@USERCODE nvarchar(15)
AS
BEGIN

	SELECT A.DMRNum, Convert(date,A.DateRequest,101) as Date_Request, B.BranchName, A.Approver_Notes, Convert(date,A.Dispatch_Date,101) as Dispatch_Date, A.Dispatch_Person, A.IsDispatch
	FROM 
	[TRANSACTION].[DM_Request_Header] A
	INNER JOIN Master.Branches B
	ON A.BranchCode = B.BranchCode
	WHERE 
	A.UserCode = @USERCODE AND a.IsPosted = 1 and a.IsPrint = 1
	ORDER BY a.DateRequest DESC
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spINSERT_BRANCH_DELIVERY]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: INSERT DELIVERY TRANSACTION

--DATE: 05/30/2018
--VERSION: 1

CREATE PROC [TRANSACTION].[spINSERT_BRANCH_DELIVERY]
@BRANCH_CODE nvarchar(10),
@DELIVERY_NUM nvarchar(20),
@DELIVERY_DATE datetime,
@REMARKS nvarchar(150),
@ITEM_CODE nvarchar(10),
@QUANTITY int

AS
BEGIN

BEGIN TRY
	BEGIN TRANSACTION

	--INSERT RECORD ON DELIVERY HEADER
	--CHECK IF ALREADY EXIST
	IF NOT EXISTS(SELECT BranchCode, DeliveryNum FROM [TRANSACTION].[Deliveries_Hdr] WHERE BranchCode=@BRANCH_CODE and DeliveryNum=@DELIVERY_NUM)
	BEGIN
		INSERT INTO [TRANSACTION].[Deliveries_Hdr]
		(branchCode, deliveryNum, deliveryDate, remarks)
		VALUES
		(@BRANCH_CODE,@DELIVERY_NUM,Convert(date, @DELIVERY_DATE,101), @REMARKS)

	END
	

	--INSERT PER ITEM IN DELIVERY LINE
	INSERT INTO [TRANSACTION].[Deliveries_Line]
	(deliveryNum,itemCode,quantity)
	VALUES
	(@DELIVERY_NUM,@ITEM_CODE,@QUANTITY)


	--INSERT INTO BRANCH TRANSACTION
	--STOCK IN
	INSERT INTO [TRANSACTION].[Branches]
	(branchCode, itemCode,referenceNum,Stock_In,dateSpecify)
	VALUES
	(@BRANCH_CODE,@ITEM_CODE,@DELIVERY_NUM,@QUANTITY,@DELIVERY_DATE)

	--UPDATE BRANCH INVENTORY STOCK
	UPDATE INVENTORY.Branches
	SET tStockIn = tStockIn + @QUANTITY,
		LastUpdate=getdate()
	WHERE branchCode=@BRANCH_CODE and itemCode = @ITEM_CODE


	--ITEM TRANSACTION
	INSERT INTO [TRANSACTION].[Items]
	(itemCode, referenceNum, quantity, invCountType)
	VALUES
	(@ITEM_CODE,@DELIVERY_NUM,@QUANTITY,1)

	COMMIT TRANSACTION
END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION -- Will not commit changes on all tables

END CATCH

	

END
GO
/****** Object:  StoredProcedure [TRANSACTION].[spINSERT_DM_DEBIT_MEMO]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* INSERT DEBIT MEMO REQUEST
03/23/201
REV. 06/07/2018
Russel Vasquez
*/

CREATE PROC [TRANSACTION].[spINSERT_DM_DEBIT_MEMO]
@DMRNUM nvarchar(15),
@BRANCHCODE nvarchar(10),
@SUPERVISORID nvarchar(50),
@ITEMID int,
@ITEMDESCRIPTION nvarchar(150),
@QUANTITY float,
@UNITPRICE float,
@AMOUNT float,
@TOTALAMOUNT float,
@OTHERS_DETAIL nvarchar(150),
@REQUESTER_NOTES nvarchar(250),
@ATTACHMENT image,
@ISATTACHMENT bit,
@DATEREQUEST datetime,
@USERCODE nvarchar(50)

AS
BEGIN

BEGIN TRY
	BEGIN TRANSACTION
	
	

	--INSERT TO HEADER
	--CHECK IF ALREADY EXIST
	IF NOT EXISTS(SELECT DMRNUM FROM [TRANSACTION].[DM_Request_Header] WHERE DMRNum=@DMRNUM)
	BEGIN
		INSERT INTO [TRANSACTION].[DM_Request_Header]
		(DMRNum,DateRequest,BranchCode,SupervisorID, totalAmountPrice,Requester_Notes,Remarks_Trail, UserCode)
		VALUES
		(@DMRNUM,@DATEREQUEST,@BRANCHCODE,@SUPERVISORID,@TOTALAMOUNT,@REQUESTER_NOTES, 'Created ' + convert(nvarchar(15), getdate(), 101), @USERCODE)
		
		EXEC [xSys].[spINSERT_DM_Audit] 'CREATE', 'REQUEST DM', @DMRNUM, @USERCODE 
	END

	

	INSERT INTO [TRANSACTION].[DM_Request_Line]
	(DMRNum, ItemID, ItemDescription, Quantity, UnitPrice, Amount, OthersDetail, Attachment,IsAttachment, DateRequest)
	VALUES
	(@DMRNUM, @ITEMID, @ITEMDESCRIPTION, @QUANTITY, @UNITPRICE,@AMOUNT, @OTHERS_DETAIL, @ATTACHMENT,@ISATTACHMENT, @DATEREQUEST)
	
	DECLARE @TRANSDESC nvarchar(150)
	SET @TRANSDESC = @DMRNUM + '-' + @ITEMDESCRIPTION + '-' + @BRANCHCODE
	EXEC [xSys].[spINSERT_DM_Audit] 'CREATE', 'REQUEST DM', @TRANSDESC, @USERCODE
	
	COMMIT TRANSACTION
END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION -- Will not commit changes on all tables

END CATCH

END

GO
/****** Object:  StoredProcedure [TRANSACTION].[spINSERT_DM_ITEM]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/11/2018>
-- Description:	<INSERT NEW ITEMS>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spINSERT_DM_ITEM]
@ITEM_DESCRIPTION nvarchar(150),
@UOM nvarchar(10),
@ITEM_GROUP nvarchar(2),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	INSERT INTO Master.DM_Item_MF
	(ItemDescription,UOM,ItemGroupCode,UserCode)
	VALUES
	(@ITEM_DESCRIPTION,@UOM,@ITEM_GROUP,@USER_CODE)

END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spUPDATE_DM_APPROVAL_DEBIT_MEMO]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* UPDATE APPROVAL
03/28/2018
Rev. 04/02/2018
Russel Vasquez
*/

CREATE PROC [TRANSACTION].[spUPDATE_DM_APPROVAL_DEBIT_MEMO]
@DMRNUM nvarchar(15),
@REQUESTSTATUS nvarchar(1),
@ID int,
@APPROVER_NOTES nvarchar(250),
@APPROVE_BY nvarchar(25)
AS
BEGIN

BEGIN TRY
	BEGIN TRANSACTION
	
	UPDATE [TRANSACTION].[DM_Request_Line]
	SET RequestStatus = @REQUESTSTATUS, DateApproved=getdate()
	WHERE ID = @ID
	
	UPDATE [TRANSACTION].[DM_Request_Header]
	SET Approver_Notes = @APPROVER_NOTES, Approve_By = @APPROVE_BY
	WHERE DMRNum = @DMRNUM
	
	DECLARE @TRANSDESC nvarchar(150)
	SET @TRANSDESC = @DMRNUM + '-' + @REQUESTSTATUS
	EXEC [xSys].[spINSERT_DM_Audit] 'DECISION', 'APPROVAL DM', @TRANSDESC, @APPROVE_BY 	
	COMMIT TRANSACTION
END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION -- Will not commit changes on all tables

END CATCH

END

GO
/****** Object:  StoredProcedure [TRANSACTION].[spUPDATE_DM_DEBIT_MEMO_HEADER_COMPLETE_STATUS]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* UPDATE COMPLETION OF DEBIT MEMO
03/28/2018
Russel Vasquez
*/

CREATE PROC [TRANSACTION].[spUPDATE_DM_DEBIT_MEMO_HEADER_COMPLETE_STATUS]
@DMRNUM nvarchar(15)
AS
BEGIN

BEGIN TRY
	BEGIN TRANSACTION
	
	-- SETTING COMPLETED THE DEBIT MEMO

	UPDATE [TRANSACTION].[DM_Request_Header]
	SET IsCompleted = 1,
	Remarks_Trail = Remarks_Trail + 'Completed : ' + Convert(nvarchar,getdate(),101) + '> ',
	DU=getdate()
	WHERE DMRNum = @DMRNUM
		
	COMMIT TRANSACTION
END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION -- Will not commit changes on all tables

END CATCH

END

GO
/****** Object:  StoredProcedure [TRANSACTION].[spUPDATE_DM_DISPATCHED]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* UPDATE DISPATCHED
06/26/2018
Russel Vasquez
*/

CREATE PROC [TRANSACTION].[spUPDATE_DM_DISPATCHED]
@DMRNUM nvarchar(15),
@DISPATCH_DATE datetime,
@DISPATCH_PERSON nvarchar(70)
AS
BEGIN

BEGIN TRY
	BEGIN TRANSACTION
	
	-- SETTING COMPLETED THE DEBIT MEMO

	UPDATE [TRANSACTION].[DM_Request_Header]
	SET IsDispatch = 1, 
	Remarks_Trail = Remarks_Trail + 'Dispatched : ' + Convert(nvarchar,getdate(),101),
	DU=getdate(), Dispatch_Date = @DISPATCH_DATE, Dispatch_Person = @DISPATCH_PERSON
	WHERE DMRNum = @DMRNUM
		
	COMMIT TRANSACTION
END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION -- Will not commit changes on all tables

END CATCH

END

GO
/****** Object:  StoredProcedure [TRANSACTION].[spUPDATE_DM_ITEM]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/17/2018>
-- Description:	<UPDATE ITEMS>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spUPDATE_DM_ITEM]
@ITEM_ID int,
@ITEM_DESCRIPTION nvarchar(150),
@UOM nvarchar(10),
@ITEM_GROUP nvarchar(3),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	UPDATE Master.DM_Item_MF
	SET ItemDescription=@ITEM_DESCRIPTION,
	UOM=@UOM,ItemGroupCode=@ITEM_GROUP, DU=getdate(),
	UserCode=@USER_CODE
	WHERE
	ItemID = @ITEM_ID
	
END


GO
/****** Object:  StoredProcedure [TRANSACTION].[spUPDATE_DM_POST_APPROVED]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* UPDATE POSTING
06/008/2018
Russel Vasquez
*/

CREATE PROC [TRANSACTION].[spUPDATE_DM_POST_APPROVED]
@DMRNUM nvarchar(15)
AS
BEGIN

BEGIN TRY
	BEGIN TRANSACTION
	
	-- SETTING COMPLETED THE DEBIT MEMO

	UPDATE [TRANSACTION].[DM_Request_Header]
	SET IsPosted = 1, 
	Remarks_Trail = Remarks_Trail + 'Posted and Print : ' + Convert(nvarchar,getdate(),101),
	DU=getdate()
	WHERE DMRNum = @DMRNUM
		
	COMMIT TRANSACTION
END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION -- Will not commit changes on all tables

END CATCH

END

GO
/****** Object:  StoredProcedure [TRANSACTION].[spUPDATE_DM_PRINTED_APPROVED]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* UPDATE PRINTED
06/008/2018
Russel Vasquez
*/

CREATE PROC [TRANSACTION].[spUPDATE_DM_PRINTED_APPROVED]
@DMRNUM nvarchar(15)
AS
BEGIN

BEGIN TRY
	BEGIN TRANSACTION
	
	-- SETTING COMPLETED THE DEBIT MEMO

	UPDATE [TRANSACTION].[DM_Request_Header]
	SET IsPrint = 1, 
	Remarks_Trail = Remarks_Trail + 'Re-Print : ' + Convert(nvarchar,getdate(),101),
	DU=getdate()
	WHERE DMRNum = @DMRNUM
		
	COMMIT TRANSACTION
END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION -- Will not commit changes on all tables

END CATCH

END

GO
/****** Object:  StoredProcedure [UTIL].[spGET_BRANCH_AREA]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF AREA FOR BRANCH LOCATION

--DATE:
--VERSION: 1

CREATE PROC [UTIL].[spGET_BRANCH_AREA]
AS
BEGIN
	SELECT * FROM 
	UTIL.Branch_Area
	ORDER BY position
END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_BRANCH_INCHARGE_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF BRANCH INCHARGE

--DATE: 05/17/2018
--VERSION: 1

CREATE PROC [UTIL].[spGET_BRANCH_INCHARGE_LIST]
AS
BEGIN
	SELECT *
	FROM [UTIL].[Branch_Incharge_RF]
	ORDER BY branchInchargeName

END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_DAYS_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF DAYS

--DATE: 05/28/2018
--VERSION: 1

CREATE PROC [UTIL].[spGET_DAYS_LIST]
AS
BEGIN
	SELECT * FROM 
	[UTIL].[Days_RF]
END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_DM_ITEM_GROUP_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF ITEM GROUP

--DATE: 06/16/2018
--VERSION: 1

CREATE PROC [UTIL].[spGET_DM_ITEM_GROUP_LIST]
AS
BEGIN
	SELECT * FROM 
	[UTIL].[Item_Group_RF]
END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_DM_REPORTS_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/12.2018>
-- Description:	<GET REPORTS REFERENCE>
-- =============================================
CREATE PROCEDURE [UTIL].[spGET_DM_REPORTS_LIST]
AS
BEGIN
	
	SELECT * FROM
	[UTIL].[Reports_RF]
	
END


GO
/****** Object:  StoredProcedure [UTIL].[spGET_DM_UOM_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF UNIT OF MEASUREMENT

--DATE: 06/16/2018
--VERSION: 1

CREATE PROC [UTIL].[spGET_DM_UOM_LIST]
AS
BEGIN
	SELECT * FROM 
	[UTIL].[UnitOfMeasurement_RF]
END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_ITEM_GROUP_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF ITEM GROUP

--DATE: 06/16/2018
--VERSION: 1

CREATE PROC [UTIL].[spGET_ITEM_GROUP_LIST]
AS
BEGIN
	SELECT * FROM 
	[UTIL].[Item_Group_RF]
END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_MACHINE_EQUIPMENT_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF MACHINE AND EQUIPMENT

--DATE: 05/19/2018
--VERSION: 1

CREATE PROC [UTIL].[spGET_MACHINE_EQUIPMENT_LIST]
AS
BEGIN
	SELECT *
	FROM [UTIL].[Machine_Equipment_RF]
	

END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_MODE_PAYMENT]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF MODE OF PAYMENT

--DATE: 05/18/2018
--VERSION: 1

CREATE PROC [UTIL].[spGET_MODE_PAYMENT]
AS
BEGIN
	SELECT * FROM 
	UTIL.Mode_Payment_RF
	ORDER BY arr
END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_STATUS_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET LIST OF AREA FOR BRANCH LOCATION

--DATE:
--VERSION: 1

CREATE PROC [UTIL].[spGET_STATUS_LIST]
AS
BEGIN
	SELECT * FROM 
	[UTIL].[Status_RF]
END
GO
/****** Object:  StoredProcedure [UTIL].[spGET_SUPERVISOR_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/29/2018>
-- Description:	<GET USER_VALIDATION>
-- =============================================
CREATE PROCEDURE [UTIL].[spGET_SUPERVISOR_LIST]
AS
BEGIN
	
	SELECT * FROM
	[UTIL].Supervisor_RF

	
END


GO
/****** Object:  StoredProcedure [UTIL].[spINSERT_DM_SUPERVISOR]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/18/2018>
-- Description:	<INSERT NEW SUPERVISOR>
-- =============================================
CREATE PROCEDURE [UTIL].[spINSERT_DM_SUPERVISOR]
@SUPERVISOR_NAME nvarchar(150),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	INSERT INTO UTIL.Supervisor_RF
	(supervisorName,usercode)
	VALUES
	(upper(@SUPERVISOR_NAME),@USER_CODE)

END


GO
/****** Object:  StoredProcedure [UTIL].[spINSERT_DM_UOM]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/19/2018>
-- Description:	<INSERT NEW Unit of Measurement>
-- =============================================
CREATE PROCEDURE [UTIL].[spINSERT_DM_UOM]
@UOM_CODE nvarchar(150),
@UOM_DESCRIPTION nvarchar(100),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	INSERT INTO UTIL.UnitOfMeasurement_RF
	(uomCode, uomDescription, userCode)
	VALUES
	(upper(@UOM_CODE),UPPER(@UOM_DESCRIPTION),@USER_CODE)

END


GO
/****** Object:  StoredProcedure [UTIL].[spUPDATE_DM_SUPERVISOR]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/18/2018>
-- Description:	<UPDATE SUPERVISOR>
-- =============================================
CREATE PROCEDURE [UTIL].[spUPDATE_DM_SUPERVISOR]
@SUPERVISORID int,
@SUPERVISOR_NAME nvarchar(150),
@IS_ACTIVE bit,
@USER_CODE nvarchar(50)

AS
BEGIN
	
	UPDATE UTIL.Supervisor_RF
	SET supervisorName=UPPER(@SUPERVISOR_NAME),
	isActive=@IS_ACTIVE,usercode=@USER_CODE,
	du=getdate()
	WHERE
	supervisorID =@SUPERVISORID
END


GO
/****** Object:  StoredProcedure [UTIL].[spUPDATE_DM_UOM]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/19/2018>
-- Description:	<UPDATE Unit of Measurement>
-- =============================================
CREATE PROCEDURE [UTIL].[spUPDATE_DM_UOM]
@UOM_ID int,
@UOM_DESCRIPTION nvarchar(100),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	UPDATE UTIL.UnitOfMeasurement_RF
	SET 
	uomDescription = upper(@UOM_DESCRIPTION),
	DU = getdate(),
	userCode = @USER_CODE
	WHERE
	uomID = @UOM_ID

END


GO
/****** Object:  StoredProcedure [xSys].[GET_MENU]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <05/10/2018>
-- Description:	<GET LIST OF MENU ITEM>
-- =============================================
CREATE PROCEDURE [xSys].[GET_MENU] 
AS
BEGIN
	SELECT * FROM
	xSys.Menu_MF
	order by menuID, arr 
END


GO
/****** Object:  StoredProcedure [xSys].[GET_SERIES_NUMBER]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: GET SERIES NUMBER SERIES

--DATE: 05/31/2018
--VERSION: 1

CREATE PROC [xSys].[GET_SERIES_NUMBER]
@PREFIXCODE nvarchar(5)
AS
BEGIN

SELECT *
FROM [xSys].[SeriesNumber_RF]
WHERE PrefixCode = @PREFIXCODE


	
END
GO
/****** Object:  StoredProcedure [xSys].[GET_SERVER_DATE_TIME]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/12/2018>
-- Description:	<GET SERVER DATE AND TIME>
-- =============================================
CREATE PROCEDURE [xSys].[GET_SERVER_DATE_TIME] 
AS
BEGIN
	SELECT GETDATE() as SERVER_DATE_TIME

END



GO
/****** Object:  StoredProcedure [xSys].[spGET_USER_LIST]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/29/2018>
-- Description:	<GET USER_VALIDATION>
-- =============================================
CREATE PROCEDURE [xSys].[spGET_USER_LIST]
AS
BEGIN
	
	SELECT * FROM
	[xSys].[User_MF]
	
END


GO
/****** Object:  StoredProcedure [xSys].[spINSERT_DM_Audit]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <07/5/2018>
-- Description:	<INSERT Audit Logs>
-- =============================================
CREATE PROCEDURE [xSys].[spINSERT_DM_Audit]
@ACTION nvarchar(50),
@MODULE nvarchar(50),
@DESCRIPTION nvarchar(150),
@USERCODE nvarchar(20)
AS
BEGIN
	
	INSERT INTO [xSys].[DM_Audit_logs]
	(action,module,description,usercode)
	VALUES
	(@ACTION,@MODULE,@DESCRIPTION,@USERCODE)

END


GO
/****** Object:  StoredProcedure [xSys].[UPDATE_SERIES_NUMBER]    Script Date: 7/5/2018 3:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TEMPLATE STORE PROCEDURE

--CREATE BY: RUSSEL VASQUEZ

--PURPOSE: UPDATE SERIES NUMBER

--DATE: 05/31/2018
--VERSION: 1



CREATE PROC [xSys].[UPDATE_SERIES_NUMBER]
@PREFIXCODE nvarchar(5)
AS
BEGIN

UPDATE [xSys].SeriesNumber_RF
SET Series = Series + 1
WHERE PrefixCode=@PREFIXCODE


END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field identify if Quantity is Increase or Decrease' , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'invCountType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Items (MASTER)"
            Begin Extent = 
               Top = 123
               Left = 879
               Bottom = 328
               Right = 1068
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Deliveries_Line (TRANSACTION)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Branches (MASTER)"
            Begin Extent = 
               Top = 11
               Left = 218
               Bottom = 316
               Right = 435
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Deliveries_Hdr (TRANSACTION)"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Branch_Incharge_RF (UTIL)"
            Begin Extent = 
               Top = 230
               Left = 0
               Bottom = 352
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Supervisor_RF (UTIL)"
            Begin Extent = 
               Top = 185
               Left = 0
               Bottom = 335
               Right = 175
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin Co' , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_BRANCH_DELIVERY_RECEIPT_SINGLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'lumnWidths = 14
         Width = 284
         Width = 1500
         Width = 2940
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_BRANCH_DELIVERY_RECEIPT_SINGLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_BRANCH_DELIVERY_RECEIPT_SINGLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[13] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Branches (MASTER)"
            Begin Extent = 
               Top = 1
               Left = 3
               Bottom = 266
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DM_Request_Header (TRANSACTION)"
            Begin Extent = 
               Top = 6
               Left = 258
               Bottom = 136
               Right = 566
            End
            DisplayFlags = 280
            TopColumn = 15
         End
         Begin Table = "DM_Request_Line (TRANSACTION)"
            Begin Extent = 
               Top = 138
               Left = 258
               Bottom = 268
               Right = 431
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DM_Item_MF (MASTER)"
            Begin Extent = 
               Top = 94
               Left = 744
               Bottom = 277
               Right = 918
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Supervisor_RF (UTIL)"
            Begin Extent = 
               Top = 188
               Left = 39
               Bottom = 331
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User_MF (xSys)"
            Begin Extent = 
               Top = 284
               Left = 547
               Bottom = 414
               Right = 745
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin Co' , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_DM_RECEIPT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'lumnWidths = 18
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2700
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 3615
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_DM_RECEIPT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_DM_RECEIPT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[17] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Branches (MASTER)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 256
               Right = 255
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "DM_Request_Header (TRANSACTION)"
            Begin Extent = 
               Top = 6
               Left = 293
               Bottom = 238
               Right = 474
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DM_Request_Line (TRANSACTION)"
            Begin Extent = 
               Top = 2
               Left = 580
               Bottom = 187
               Right = 793
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "DM_Request_Status_RF (UTIL)"
            Begin Extent = 
               Top = 71
               Left = 863
               Bottom = 256
               Right = 1054
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Supervisor_RF (UTIL)"
            Begin Extent = 
               Top = 199
               Left = 542
               Bottom = 329
               Right = 717
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1' , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_DM_REQUEST_STATUS_MONITORING'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 3435
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_DM_REQUEST_STATUS_MONITORING'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'TRANSACTION', @level1type=N'VIEW',@level1name=N'VR_DM_REQUEST_STATUS_MONITORING'
GO
