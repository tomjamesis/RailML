CREATE TABLE [dbo].[EReplacedTrains]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EReplacedTrainsId]	BIGINT		NOT NULL,
	[ReplacementOf]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EReplacedTrainsId] PRIMARY KEY CLUSTERED ([EReplacedTrainsId] ASC),
	CONSTRAINT [FK_EReplacedTrains_EReplacementOf] FOREIGN KEY ([ReplacementOf]) REFERENCES [dbo].[EReplacementOf] ([EReplacementOfId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
