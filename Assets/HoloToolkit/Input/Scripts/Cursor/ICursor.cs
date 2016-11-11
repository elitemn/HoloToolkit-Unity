﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace HoloToolkit.Unity.InputModule
{
    /// <summary>
    /// Cursor Interface for handling input events and setting visiblity.
    /// </summary>
    public interface ICursor : IInputHandler, ISourceStateHandler
    {
        /// <summary>
        /// Position of the cursor.
        /// </summary>
        Vector3 Position { get; }

        /// <summary>
        /// Rotation of the cursor.
        /// </summary>
        Quaternion Rotation { get; }

        /// <summary>
        /// Local scale of the cursor.
        /// </summary>
        Vector3 LocalScale { get; }

        /// <summary>
        /// Sets the visibility of the cursor.
        /// </summary>
        /// <param name="visible">True if cursor should be visible, false if not.</param>
        void SetVisiblity(bool visible);
    }
}