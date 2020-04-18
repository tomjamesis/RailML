CREATE TABLE [dbo].[TTrainRadioAttributes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainRadioAttributesId]			BIGINT			NOT NULL,
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

	CONSTRAINT [PK_TTrainRadioAttributesId] PRIMARY KEY CLUSTERED ([TTrainRadioAttributesId] ASC)
);
