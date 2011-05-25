﻿
#light

namespace Vim
open Microsoft.VisualStudio.Text
open Microsoft.VisualStudio.Text.Editor
open Microsoft.VisualStudio.Text.Operations
open Microsoft.VisualStudio.Utilities
open System.ComponentModel.Composition

/// Used to track changes to an individual IVimBuffer
type internal TextChangeTracker =
    interface ITextChangeTracker

    new : IVimBuffer * IKeyboardDevice * IMouseDevice -> TextChangeTracker
    