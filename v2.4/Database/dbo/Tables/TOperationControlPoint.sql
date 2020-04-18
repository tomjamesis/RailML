CREATE TABLE [dbo].[TOperationControlPoint]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOperationControlPointId]	SMALLINT			NOT NULL,
	[ControllerRef]			SMALLINT			NOT NULL,
	[Number]					NVARCHAR(MAX)	NOT NULL,
	[Abbrevation]				NVARCHAR(MAX)	NOT NULL,
	[Timezone]					NVARCHAR(MAX)	NOT NULL,
	[ParentOcpRef]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOperationControlPointId] PRIMARY KEY CLUSTERED ([TOperationControlPointId] ASC),
	CONSTRAINT [FK_TOperationControlPoint_TElementRefInGroup] FOREIGN KEY ([ControllerRef]) REFERENCES [dbo].[TElementRefInGroup] ([TElementRefInGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
