CREATE TABLE [dbo].[TOrientedElement]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOrientedElementId]	SMALLINT		NOT NULL,
	[DirValue]			TINYINT		NOT NULL,
	[DirValueSpecified]BIT			NOT NULL,

	CONSTRAINT [PK_TOrientedElementId] PRIMARY KEY CLUSTERED ([TOrientedElementId] ASC),
	CONSTRAINT [FK_TOrientedElement_TLaxDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TLaxDirection] ([TLaxDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
