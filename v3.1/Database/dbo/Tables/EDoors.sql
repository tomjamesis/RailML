CREATE TABLE [dbo].[EDoors]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EDoorsId]			SMALLINT		NOT NULL,
	[PassengerFlowSpeed]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EDoorsId] PRIMARY KEY CLUSTERED ([EDoorsId] ASC),
	CONSTRAINT [FK_EDoors_TPassengerFlowSpeed] FOREIGN KEY ([PassengerFlowSpeed]) REFERENCES [dbo].[TPassengerFlowSpeed] ([TPassengerFlowSpeedId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
