CREATE TABLE [dbo].[TOrientedElementWithLength]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOrientedElementWithLengthId]	SMALLINT		NOT NULL,
	[DirValue]						TINYINT		NOT NULL,
	[DirValueSpecified]			BIT			NOT NULL,

	CONSTRAINT [PK_TOrientedElementWithLengthId] PRIMARY KEY CLUSTERED ([TOrientedElementWithLengthId] ASC),
	CONSTRAINT [FK_TOrientedElementWithLength_TLaxDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TLaxDirection] ([TLaxDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
