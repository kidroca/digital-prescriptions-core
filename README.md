# Digital Prescriptions 

## Disclaimer

This is a non commercial project created for education purposes on using the APS.NET Core technology

---

## Abstract

The patient registers to the system by converting his existing paper "reception book" at a pharmacy
He's granted an on-line account where he can monitor his, now digital, reception records 
He can setup a monthly schedule for medication delivery with the pharmacy 

## Primary Goals

1. Medication and Medical supplies shipment tracking
2. Allow medical staff to manage (edit/update) individual patient prescriptions

## User Roles | Claims

- **Admin** - access on all system levels

- **Hospital** - Health-care provider accounts - doctors and nurses
	- Access to patient records (Needs patient confirmation) 
	- Read/Write to patient prescriptions

- **Patient** - The primary user/client account
	- Reads information about his own prescription
	- Reads information about his own shipments of medications

- **Pharmacy** - Manages deliveries 
	- a patient would share his data with a Pharmacy provider 
	- Read access to patient prescription
	- Read/Write access to shipments
