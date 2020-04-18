CREATE TABLE [dbo].[TTrainRadioChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainRadioChangeId]				SMALLINT			NOT NULL,
	[RadioSystem]						NVARCHAR(MAX)	NOT NULL,
	[NetworkSelection]					NVARCHAR(MAX)	NOT NULL,
	[PublicEmergencyValue]				BIT				NOT NULL,
	[PublicEmergencyValueSpecified]	BIT				NOT NULL,
	[BroadcastCallsValue]				BIT				NOT NULL,
	[BroadcastCallsValueSpecified]		BIT				NOT NULL,
	[TextMessageServiceValue]			BIT				NOT NULL,
	[TextMessageServiceValueSpecified]	BIT				NOT NULL,
	[DirectModeValue]					BIT				NOT NULL,
	[DirectModeValueSpecified]			BIT				NOT NULL,
	[PublicNetworkRoamingValue]		BIT				NOT NULL,
	[PublicNetworkRoamingValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TTrainRadioChangeId] PRIMARY KEY CLUSTERED ([TTrainRadioChangeId] ASC)
);
