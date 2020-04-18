CREATE TABLE [dbo].[ESpeedChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ESpeedChangesId]	BIGINT		NOT NULL,
	[SpeedChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ESpeedChangesId] PRIMARY KEY CLUSTERED ([ESpeedChangesId] ASC),
	CONSTRAINT [FK_ESpeedChanges_TSpeedChange] FOREIGN KEY ([SpeedChange]) REFERENCES [dbo].[TSpeedChange] ([TSpeedChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
