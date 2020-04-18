CREATE TABLE [dbo].[TController]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TControllerId]				SMALLINT			NOT NULL,
	[States]						BIGINT			NOT NULL,
	[OcpRef]						SMALLINT			NOT NULL,
	[ParentControllerRef]			NVARCHAR(MAX)	NOT NULL,
	[Model]						NVARCHAR(MAX)	NOT NULL,
	[Type]							NVARCHAR(MAX)	NOT NULL,
	[TechnologyTypeValue]			TINYINT			NOT NULL,
	[TechnologyTypeValueSpecified]	BIT				NOT NULL,
	[SwVersion]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TControllerId] PRIMARY KEY CLUSTERED ([TControllerId] ASC),
	CONSTRAINT [FK_TController_TElementRefInGroup] FOREIGN KEY ([OcpRef]) REFERENCES [dbo].[TElementRefInGroup] ([TElementRefInGroupId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TController_TStates] FOREIGN KEY ([States]) REFERENCES [dbo].[TStates] ([TStatesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TController_TControllerTechnologyType] FOREIGN KEY ([TechnologyTypeValue]) REFERENCES [dbo].[TControllerTechnologyType] ([TControllerTechnologyTypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
