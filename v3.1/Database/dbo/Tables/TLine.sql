CREATE TABLE [dbo].[TLine]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLineId]					SMALLINT			NOT NULL,
	[States]					BIGINT			NOT NULL,
	[Type]						NVARCHAR(MAX)	NOT NULL,
	[InfrastructureManagerRef]	NVARCHAR(MAX)	NOT NULL,
	[LineCategory]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TLineId] PRIMARY KEY CLUSTERED ([TLineId] ASC),
	CONSTRAINT [FK_TLine_TStates] FOREIGN KEY ([States]) REFERENCES [dbo].[TStates] ([TStatesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
