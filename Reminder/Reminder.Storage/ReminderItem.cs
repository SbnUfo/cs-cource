﻿using System;

namespace Reminder.Storage
{
	/// <summary>
	///   Represents one reminder
	/// </summary>
	public class ReminderItem
	{
		/// <summary>
		///   Unique identifier
		/// </summary>
		public Guid Id { get; }

		/// <summary>
		///   Date and time to sent in UTC format
		/// </summary>
		public DateTimeOffset DateTime { get; private set; }

		/// <summary>
		///   The status from <see cref="ReminderItemStatus"/>
		/// </summary>
		public ReminderItemStatus Status { get; private set; }

		/// <summary>
		///   Entered user message
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		///   User id/number/email from telegram
		/// </summary>
		public string ContactId { get; private set; }

		/// <summary>
		/// Represents user information
		/// </summary>
		/// <param name="id"></param>
		/// <param name="status"></param>
		/// <param name="datetime"></param>
		/// <param name="message"></param>
		/// <param name="contactId"></param>
		public ReminderItem(
			Guid id,
			ReminderItemStatus status,
			DateTimeOffset datetime,
			string message,
			string contactId)
		{
			Id = id;
			Status = status;
			DateTime = datetime;
			Message = message;
			ContactId = contactId;
		}

		public override string ToString() =>
			$"Reminder (id: {Id}, status: {Status}) at {DateTime:O} to {ContactId}";
	}
}