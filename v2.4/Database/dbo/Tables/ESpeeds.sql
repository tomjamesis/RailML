CREATE TABLE [dbo].[ESpeeds]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ESpeedsId]	BIGINT		NOT NULL,
	[Speed]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ESpeedsId] PRIMARY KEY CLUSTERED ([ESpeedsId] ASC),
	CONSTRAINT [FK_ESpeeds_TSpeedInfo] FOREIGN KEY ([Speed]) REFERENCES [dbo].[TSpeedInfo] ([TSpeedInfoId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
