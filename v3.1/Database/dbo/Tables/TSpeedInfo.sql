CREATE TABLE [dbo].[TSpeedInfo]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSpeedInfoId]		BIGINT			NOT NULL,
	[TrainCategory]	NVARCHAR(MAX)	NOT NULL,
	[EtcsTrainCategory]	NVARCHAR(MAX)	NOT NULL,
	[ProfileRef]		NVARCHAR(MAX)	NOT NULL,
	[Status]			NVARCHAR(MAX)	NOT NULL,
	[VMax]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSpeedInfoId] PRIMARY KEY CLUSTERED ([TSpeedInfoId] ASC)
);
